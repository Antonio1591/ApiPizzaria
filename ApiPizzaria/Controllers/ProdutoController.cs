using ApiPizzaria.Model.Input;
using ApiPizzaria.Model.View;
using ApiPizzaria.Services;
using Microsoft.AspNetCore.Mvc;


namespace ApiPizzaria.Controllers
{
    [Route("apiProdutos/[controller]")]
    //[Authorize]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServices _iProdutoServices;

        public ProdutoController(IProdutoServices iProdutoServices)
        {
            _iProdutoServices = iProdutoServices;
        }
        [HttpPost("CadastroProduto")]
        public async Task<ActionResult<ProdutoViewModel>> CadastrarProduto(ProdutoInputModel produtoInput)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var CadastrarProduto = await _iProdutoServices.CadastrarProduto(produtoInput);

            if (CadastrarProduto == null)
                return BadRequest("Dados não encontrados, ou alguma informação incoerente favor verificar o cadastro da mercadoira");

            return Ok(CadastrarProduto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> BuscarProdutos()
        {
           var ProdutosEncontrados= await _iProdutoServices.BuscarProdutos();
            if (ProdutosEncontrados == null)
                return BadRequest("Nenhum Produto Encontrado!");

            return Ok(ProdutosEncontrados);
        }
    }
}
