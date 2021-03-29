using AutoMapper;
using MT.OnlineRestaurant.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MT.OnlineRestaurant.BusinessLayer;
using MT.OnlineRestaurant.BusinessLayer.interfaces;
using MT.OnlineRestaurant.DataLayer;
using MT.OnlineRestaurant.DataLayer.Context;
using MT.OnlineRestaurant.DataLayer.interfaces;
using MT.OnlineRestaurant.ValidateUserHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingManagement;
using Microsoft.OpenApi.Models;

namespace MT.OnlineRestaurant.OrderAPI
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
            services.AddTransient<IPlaceOrderActions, PlaceOrderActions>();
            services.AddTransient<IPlaceOrderDbAccess, PlaceOrderDbAccess>();
            services.AddTransient<IPaymentActions, PaymentActions>();
            services.AddTransient<IPaymentDbAccess, PaymentDbAccess>();
            services.AddTransient<IBookYourTableBusiness, BookYourTableBusiness>();
            services.AddTransient<IBookYourTableRepository, BookYourTableRepository>();
            services.AddTransient<ILogService, LoggerService>();
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));

            services.AddDbContext<OrderManagementContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"),
               b => b.MigrationsAssembly("MT.OnlineRestaurant.DataLayer")));
            services.AddSwaggerGen(c =>
            {   
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderManager", Version = "v1" });
                c.OperationFilter<HeaderFilter>();
            });
            services.AddControllers(o =>
            {
                o.Filters.Add(new Authorization());
                o.Filters.Add(new LoggingFilter(Configuration.GetConnectionString("DatabaseConnectionString")));
                o.Filters.Add(new ErrorHandlingFilter(Configuration.GetConnectionString("DatabaseConnectionString")));
            } ) ; 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MT.OnlineRestaurant.CustomerManagement v1"));
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
