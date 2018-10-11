using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


using DynamicsGPAPI.Services;
using DynamicsGPAPI.Entities;

namespace DynamicsGPAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true)
                              .AddUserSecrets<Startup>();


            //if (env.IsDevelopment())
            //    builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();


        }

      

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           

            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<DynamicsGPAPI.Entities.Pm00300, Models.Pm00300DTO>();
                config.CreateMap<Models.Pm00300DTO, Entities.Pm00300>();
            });

            var conn = Configuration["connectionsStrings:dynamicsGPJDFConnection"];
           //  services.AddDbContext<JDFContext>(options => options.UseSqlServer(conn));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1,", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Title = "Dynamics GP API",
                    Version = "v1"

                });

                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);
            });

            services.AddMvc();

            services.AddScoped(typeof(IGenericEFFactory), typeof(IGenericEFFactory));

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dynamics GP API");
            });

            

            app.UseMvc();
        }
    }
}
