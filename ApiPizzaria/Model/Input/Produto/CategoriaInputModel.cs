namespace ApiPizzaria.Model.Input
{
    public class CategoriaInputModel
    {
        public int IdCategoria { get; private set; }
        public string NomeCategoria { get; private set; }
        public string Descricao { get; private set; }
        public SituacaoCategoriaEnum SituacaoCategoria { get; private set; }
    }
}
