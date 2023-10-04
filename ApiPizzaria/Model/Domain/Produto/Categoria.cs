using System.ComponentModel.DataAnnotations;

namespace ApiPizzaria.Model.Domain

{
    public class Categoria
    {
        
        public int Id { get; private set; }
        public string NomeCategoria { get; private set; }
        public string Descricao { get; private set; }
        public SituacaoCategoriaEnum SituacaoCategoria { get; private set; }
    }

    public class SubCategoria 
    {
      
        public int Id { get; private set; }
        public Categoria Categoria { get; private set; }
        public string NomeSubCategoria { get; private set; }
        public string Descricao { get; private set; }
        public SituacaoSubCategoriaEnum SituacaoSubCategoria { get; private set; }
    }
}
