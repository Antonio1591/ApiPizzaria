using ApiPizzaria.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiPizzaria.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<Estoque> estoque { get; set; }
        public DbSet<CarrinhoPedido> carrinhoPedido { get; set; }
        public DbSet<Venda> venda { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<SubCategoria> subCategorias { get; set; } 
    }
}
