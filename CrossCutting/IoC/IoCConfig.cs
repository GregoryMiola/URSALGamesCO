using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.IoC
{
    /// <summary>
    /// Classe responsável pela configuração da injeção de dependências do sistema 
    /// </summary>
    public class IoCConfig
    {
        /// <summary>
        /// Método que registra todas as classes/interfaces que serão injetadas no sistema
        /// </summary>
        /// <param name="services">Serviço de configuração da injeção de dependência</param>
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            //services.AddTransient<ISaleService, SaleService>();
            //services.AddTransient<IHttpHandler, HttpClientHandler>();
            #endregion Services

            #region Repositories
            //services.AddTransient<ISaleRepository, SaleRepository>();
            #endregion Repositories

            #region Contexts
            //services.AddTransient<SalesContext>();
            #endregion Contexts
        }
    }
}
