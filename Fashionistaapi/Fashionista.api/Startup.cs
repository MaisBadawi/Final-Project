
using Fashionista.core.Common;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using Fashionista.infra.Common;
using Fashionista.infra.Repository;
using Fashionista.infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashionista.api
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
            services.AddScoped<IdbContext, dbContext>();


            services.AddScoped<IProductRepository, ProductRepository>();//pro
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IPropertyRepository, PropertyRepository>();//prop
            services.AddScoped<IPropertyService, PropertyService>();

            services.AddScoped<IPaymentRepository, PaymentRepository>();//pay
            services.AddScoped<IPaymentService, PaymentService>();

            services.AddControllers();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
