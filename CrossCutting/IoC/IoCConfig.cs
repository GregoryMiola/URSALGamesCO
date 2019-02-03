using Data.SQLite.Context;
using Data.SQLite.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.IoC
{
    /// <summary>
    /// Class responsible for configuring system dependency injection 
    /// </summary>
    public class IoCConfig
    {
        #region Methods

        /// <summary>
        /// Method that registers all classes / interfaces that will be injected into the system
        /// </summary>
        /// <param name="services">Dependency Injection Configuration Service</param>
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

        #endregion Methods
    }
}
