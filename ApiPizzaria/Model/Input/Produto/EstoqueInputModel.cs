using ApiPizzaria.Model.Domain;

namespace ApiPizzaria.Model.Input
{ 
    public class EstoqueInputModel
    {
        public int Id { get; set; }
        public Produto Produto { get;  set; }
        public int QuantidadeEstoque { get;  set; }
    }
}

