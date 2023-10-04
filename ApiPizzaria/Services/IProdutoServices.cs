using ApiPizzaria.Data;
using ApiPizzaria.Model.Domain;
using ApiPizzaria.Model.Input;
using ApiPizzaria.Model.Mapping;
using ApiPizzaria.Model.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ApiPizzaria.Services
{
    public interface IProdutoServices
    {
        public Task<ProdutoViewModel> CadastrarProduto(ProdutoInputModel inputModel);
        public Task<ProdutoViewModel> AtualizarProduto(ProdutoInputModel inputModel);
        public Task<ProdutoViewModel> BuscarProdutoId(ProdutoInputModel inputModel);
        public Task<IEnumerable<ProdutoViewModel>> BuscarProdutos();


    }
    public class ProdutoServices : IProdutoServices
    {
        private readonly DataContext _context;
        private readonly IEstoqueServices _estoqueServices;
        public ProdutoServices(DataContext context, IEstoqueServices estoqueServices)
        {
            _context = context;
            _estoqueServices = estoqueServices;
        }

        public async Task<ProdutoViewModel> CadastrarProduto(ProdutoInputModel inputModel)
        {
            var produto = new Produto(inputModel.Descriscao, inputModel.ValorProduto, inputModel.Imagem);
            if (produto == null)
                return null;
            await _context.produto.AddAsync(produto);
            await _context.SaveChangesAsync();
            var estoqueInputModel = new EstoqueInputModel { Produto = produto, QuantidadeEstoque = 0 };
            var cadastroEstoque = await _estoqueServices.CadastrarEstoqueProduto(estoqueInputModel);



            return new ProdutoViewModel
            {
                Id = produto.Id,
                Descriscao = produto.Descriscao,
                Categoria = produto.Categoria.Descricao,
                SubCategoria = produto.SubCategoria.Descricao,
                ValorProduto = produto.ValorProduto,
                Imagem = produto.Imagem,
                QauntidadeEstoque = cadastroEstoque.QuantidadeEstoque
            };
        }
        public Task<ProdutoViewModel> AtualizarProduto(ProdutoInputModel inputModel)
        {

            throw new NotImplementedException();
        }

        public Task<ProdutoViewModel> BuscarProdutoId(ProdutoInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoViewModel>> BuscarProdutos()
        {
            throw new NotImplementedException();
        }

    }
}
