using Data.SQLite.Context;
using Data.SQLite.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

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
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IGameResultService, GameResultService>();
            #endregion Services

            #region Repositories
            services.AddTransient<IGameRepository, GameRepository>();
            services.AddTransient<IGameResultRepository, GameResultRepository>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            #endregion Repositories

            #region Contexts
            services.AddTransient<URSALGamesCOContext>();
            #endregion Contexts
        }
    }
}
