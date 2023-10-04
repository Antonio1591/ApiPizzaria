using ApiPizzaria.Model.Domain;
using ApiPizzaria.Model.View;
using System.Runtime.CompilerServices;

namespace ApiPizzaria.Model.Mapping
{
    public static class ProdutoMapping
    {
        public static ProdutoViewModel ParaViewModel(this Produto produto)
        {
            return new ProdutoViewModel
            {
                Id = produto.Id,
                Descriscao = produto.Descriscao,
                ValorProduto = produto.ValorProduto,
                Categoria = produto.Categoria.Descricao,
                SubCategoria = produto.SubCategoria.Descricao,
                Imagem = produto.Imagem,
                QauntidadeEstoque=produto.Estoque.QuantidadeEstoque
                
            };
        }
    }
}
