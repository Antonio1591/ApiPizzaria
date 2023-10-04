using ApiPizzaria.Model.Input;
namespace ApiPizzaria.Services
{
    public interface ICarrinhoServices
    {
        public bool AdicionarProdutoCarrinho(ProdutoInputModel ProdutoCarrinho);
        public bool RemoverProdutoCarrinho(ProdutoInputModel ProdutoCarrinho);
    }

    public class CarrinhoServices : ICarrinhoServices
    {
        bool ICarrinhoServices.AdicionarProdutoCarrinho(ProdutoInputModel ProdutoCarrinho)
        {
            throw new NotImplementedException();
        }

        bool ICarrinhoServices.RemoverProdutoCarrinho(ProdutoInputModel ProdutoCarrinho)
        {
            throw new NotImplementedException();
        }
    }
}
