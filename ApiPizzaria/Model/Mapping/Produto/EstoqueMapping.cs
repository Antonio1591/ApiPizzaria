using ApiPizzaria.Model.Domain;
using ApiPizzaria.Model.View;

namespace ApiPizzaria.Model.Mapping
{
    public static class EstoqueMapping
 
    {
        public static EstoqueViewModel ParaViewModel(this Estoque estoque)
        {
            return new EstoqueViewModel
            {
                Id = estoque.Id,
                IdProduto = estoque.Produto.Id,
                ProdutoDescriscao = estoque.Produto.Descriscao,
                QuantidadeEstoque = estoque.QuantidadeEstoque
            };
        }
    }
}
