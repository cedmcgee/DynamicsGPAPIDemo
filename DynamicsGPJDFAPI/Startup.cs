using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DynamicsGPJDFAPI.Services;
using AutoMapper;
using Swashbuckle.AspNetCore;



namespace DynamicsGPJDFAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            builder.AddUserSecrets<Startup>();
           

                


            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           var conn = Configuration["connectionStrings:dynamicsGPJDFConnection"];
           services.AddDbContext<JdfDbContext>(options => options.UseSqlServer(conn));
            // Add framework services.
            services.AddMvc();

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Models.Pm00300DTO, Entities.Pm00300>();
                config.CreateMap<Entities.Pm00300,Models.Pm00300DTO >();
                config.CreateMap<Entities.Rm00101, Models.Rm00101DTO>();
                config.CreateMap<Models.Rm00101DTO, Entities.Rm00101>();
                config.CreateMap<Models.Iv00101DTO, Entities.Iv00101>();
                config.CreateMap<Entities.Iv00101, Models.Iv00101DTO>();
                config.CreateMap<Models.Rm10201DTO, Entities.Rm10201>();
                config.CreateMap<Entities.Rm10201, Models.Rm10201DTO>();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "DynamicsGP JDF API",
                    Version = "v1"
                });

                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);

            });

            services.AddScoped(typeof(Services.IGenericEFFactory), typeof(Services.GenericEFRepository));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();
            // Enable middleware to serve swagger-ui ( HTML, JS, CSS, etc ), specifiying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DynamicsGP JDF API");

            });
            app.UseMvc();
        }
    }
}
