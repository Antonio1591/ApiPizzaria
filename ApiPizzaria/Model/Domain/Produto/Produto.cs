using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPizzaria.Model.Domain
{ 
    public class Produto
    {
        public Produto(string descriscao, double valorProduto,string imagem)
        {
            Descriscao = descriscao;
            ValorProduto = valorProduto;
            Imagem = imagem;
        }

        public int Id { get; set; }
        public string Descriscao { get; private set; }
        public double ValorProduto { get; private set; }
        public Categoria Categoria { get; private set; }
        public SubCategoria SubCategoria { get; private set; } 
        public string Imagem { get; private set; }

        [NotMapped]
        public Estoque Estoque { get; private set; }
    }
}
