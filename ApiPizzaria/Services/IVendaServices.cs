using ApiPizzaria.Model.Domain;
using ApiPizzaria.Model.View;

namespace ApiPizzaria.Services
{
    public interface IVendaServices
    {
        public VendaViewModel FinalizarVenda(CarrinhoPedido CarrinhoPedido);
    }
    public class VendaServices : IVendaServices
    {
        VendaViewModel IVendaServices.FinalizarVenda(CarrinhoPedido CarrinhoPedido)
        {
            throw new NotImplementedException();
        }
    }
}
