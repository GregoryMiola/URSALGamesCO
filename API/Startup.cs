using CrossCutting.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.Globalization;
using System.IO;

namespace API
{
    /// <summary>
    /// ?????
    /// </summary>
    public class Startup
    {
        #region Properties

        #endregion
        /// <summary>
        /// ?????
        /// </summary>
        public IConfiguration Configuration { get; }

        #region Properties

        #endregion
        /// <summary>
        /// ?????
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //services.AddDbContext<URSALGamesCOContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("URSALGamesCODB")));
            //services.AddEntityFrameworkSqlite()
            //.AddDbContext<URSALGamesCOContext>(
            //    options => { options.UseSqlite($"Data Source={_appEnv.ApplicationBasePath}/data.db"); });

            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);

            services.AddResponseCompression();

            //// Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "API ...",
                    Description = "API de Exemplo"
                });

                // Set the comments path for the Swagger JSON and UI.
                string applicationPath = PlatformServices.Default.Application.ApplicationBasePath;
                string applicationName = PlatformServices.Default.Application.ApplicationName;
                string pathXmlDoc = Path.Combine(applicationPath, $"{applicationName}.xml");
                c.IncludeXmlComments(pathXmlDoc);
            });

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                c.RoutePrefix = "swagger/ui";
            });

            app.UseMvc();

            var cultureInfo = new CultureInfo("pt-BR");

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        private static void RegisterServices(IServiceCollection services)
        {
            IoCConfig.RegisterServices(services);
        }
    }
}
