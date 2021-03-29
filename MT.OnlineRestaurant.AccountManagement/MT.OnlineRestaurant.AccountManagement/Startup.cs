using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MT.OnlineRestaurant.BusinessLayer;
using MT.OnlineRestaurant.BusinessLayer.Interfaces;
using MT.OnlineRestaurant.DataLayer;
using MT.OnlineRestaurant.DataLayer.Context;
using MT.OnlineRestaurant.DataLayer.Interfaces;
using MT.OnlineRestaurant.Logging;
using MT.OnlineRestuarant.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.AccountManagement
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MT.OnlineRestaurant.AccountManagement", Version = "v1" });
            });
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddTransient<IUserDataAccess, UserDataAccess>();
            services.Configure<ApplicationString>(Configuration.GetSection("ApplicationString"));
            services.AddMvc(
                          config =>
                          {
                              config.Filters.Add(new LoggingFilter(Configuration.GetConnectionString("DatabaseConnectionString")));
                              config.Filters.Add(new ErrorHandlingFilter(Configuration.GetConnectionString("DatabaseConnectionString")));

                          });
            //addedd
            services.AddDbContext<CustomerManagementContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"), b => b.MigrationsAssembly("MT.OnlineRestuarant.DataLayer")));

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MT.OnlineRestaurant.AccountManagement v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
