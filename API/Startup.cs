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
    /// Project startup class
    /// </summary>
    public class Startup
    {
        #region Properties

        /// <summary>
        /// Project configuration property
        /// </summary>
        public IConfiguration Configuration { get; }

        #endregion Properties

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="configuration">Project configuration</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion Ctor

        #region Methods

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Collection of configuration services of project</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors(o => o.AddPolicy("URSALGamesCO", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));

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

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Application Builder</param>
        /// <param name="env">Hosting environment</param>
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

        /// <summary>
        /// This method called for register IoC of project
        /// </summary>
        /// <param name="services">Collection of configuration services of project</param>
        private static void RegisterServices(IServiceCollection services)
        {
            IoCConfig.RegisterServices(services);
        }

        #endregion Methods
    }
}
