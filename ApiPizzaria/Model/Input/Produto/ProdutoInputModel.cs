namespace ApiPizzaria.Model.Input
{ 
    public class ProdutoInputModel
    {
        public int Id { get; set; }
        public string Descriscao { get;  set; }
        public double ValorProduto { get;  set; }
        public string Categoria { get;  set; }
        public string Imagem { get; set; }
    }
}
