using ApiPizzaria.Model.Domain;

public class Estoque
{
    protected Estoque() { }
    public Estoque(Produto produto, int quantidadeEstoque)
    {
        Produto = produto;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public int Id { get; set; }
    public Produto Produto { get; private set; }
    public int QuantidadeEstoque { get; private set; }
}