using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TestProject.Domain.Factories;
using TestProject.Domain.Model;
using TestProject.Domain.Services;
using TestProject.Interfaces;
using TestProject.Repositories.Services;

namespace TestProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IGeneralFactory, GeneralFactory>();
            services.AddTransient<IGeneralService, GeneralService>();
            services.AddTransient<ILookUpRepository, LookUpRepository>();
            services.AddTransient<IPerson, PersonModel>();
            services.AddTransient<IPersonView, PersonView>();

            // Add service and create Policy with options
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());  //cors 
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseDefaultFiles();
            app.UseCors("CorsPolicy");



           app.UseMvc(routes=>{     
                routes.MapSpaFallbackRoute(name:"spa-fallback",defaults:new{  //this is just telling our app to redirect to the controller if it dosent undertsand the route
                    Controller="Fallback",Action="Index"  
                });
            });
        }
    }
}
