namespace ApiPizzaria.Model.Domain
{
    public class Venda
    {
        public int Id { get; set; }
        public Produto Produto { get; private set; }
        public string  CPF { get; private set; }
        public double PrecoVenda { get; private set; }
        public double PromocaoVenda { get; private set; }
        public SituacaoVendasEnum Situacao { get; private set; }      
    }
}