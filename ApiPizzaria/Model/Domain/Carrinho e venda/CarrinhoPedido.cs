
namespace ApiPizzaria.Model.Domain
{
   public class CarrinhoPedido
    {
        public int Id { get; private set; }
        public List<Produto> ProdutoCarrinho { get; private set; }    
        public double ValorDescontoCarrinho { get; private set; }
        public double ValorProdutoCarrinho { get;  private set; }
        public int Quantidade { get; private set; }
        public SituacaoCarrinhoEnum SituacaoCarrinho { get; private set; }
    }
}
