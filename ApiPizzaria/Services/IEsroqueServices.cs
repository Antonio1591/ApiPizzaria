using ApiPizzaria.Data;
using ApiPizzaria.Model.Input;
using ApiPizzaria.Model.Mapping;
using ApiPizzaria.Model.View;

namespace ApiPizzaria.Services
{
    public interface IEstoqueServices
    {
        public Task<EstoqueViewModel> CadastrarEstoqueProduto(EstoqueInputModel estoqueInputModel);
        public Task<EstoqueViewModel> AtualizarEstoqueProduto(EstoqueInputModel estoqueInputModel);
    }
    public class EstoqueServices : IEstoqueServices
    {
        private readonly DataContext _context;

        public EstoqueServices(DataContext context)
        {
            _context = context;
        }

        public async Task<EstoqueViewModel> CadastrarEstoqueProduto(EstoqueInputModel estoqueInputModel)
        {
            var AdicioanrEstoque = new Estoque(estoqueInputModel.Produto,estoqueInputModel.QuantidadeEstoque);
            if(AdicioanrEstoque == null)
            {
                throw new NotImplementedException();
            }
            await _context.estoque.AddAsync(AdicioanrEstoque);
            await _context.SaveChangesAsync();
            return AdicioanrEstoque.ParaViewModel();
        } 
        public Task<EstoqueViewModel> AtualizarEstoqueProduto(EstoqueInputModel estoqueInputModel)
        {
            throw new NotImplementedException();
        }

       
    }
}
