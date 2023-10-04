using ApiPizzaria.Data;
using ApiPizzaria.Services;
using Microsoft.EntityFrameworkCore;

namespace ApiPizzaria.Extensions
{
    public static class ConfiguracoesExtensions
    {
        public static void ConfiguracaoBancoDeDados(this IServiceCollection builder,IConfiguration configuration)
        {
            string stringConexao = configuration.GetConnectionString("conexaoMysql");

            builder.AddDbContext<DataContext>(opt=>
            opt.UseMySql(stringConexao,ServerVersion.AutoDetect(stringConexao))
            .UseSnakeCaseNamingConvention());

        }
        public static void InjecaoDepencias(this IServiceCollection builder)
        {
            builder.AddScoped<IProdutoServices,ProdutoServices>();
            builder.AddScoped<IEstoqueServices, EstoqueServices>();
            builder.AddScoped<ICarrinhoServices, CarrinhoServices>();
            builder.AddScoped<IVendaServices, VendaServices>();
        }
    }

}
