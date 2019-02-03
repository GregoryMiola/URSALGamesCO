using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace API
{
    /// <summary>
    /// Class of Program project
    /// </summary>
    public class Program
    {
        #region Methods

        /// <summary>
        /// Main project method
        /// </summary>
        /// <param name="args">Arguments of method</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Build Web Host Builder
        /// </summary>
        /// <param name="args">Arguments of method</param>
        /// <returns>Application Settings</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        #endregion Methods
    }
}
