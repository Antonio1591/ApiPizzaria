using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPizzaria.Model.View
{ 
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Descriscao { get;  set; }
        public double ValorProduto { get;  set; }
        public string Categoria { get;  set; }
        public string SubCategoria { get; set; }
        public string Imagem { get;  set; }
        public int QauntidadeEstoque { get; set; }

    }
}
