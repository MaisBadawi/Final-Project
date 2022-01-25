
using Fashionista.core;
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


            services.AddScoped<IProductRepository, ProductRepository>();//1.pro
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IPropertyRepository, PropertyRepository>();//2.prop
            services.AddScoped<IPropertyService, PropertyService>();

            services.AddScoped<IPaymentRepository, PaymentRepository>();//3.pay
            services.AddScoped<IPaymentService, PaymentService>();
            
            services.AddScoped<IAgeRepository, AgeRepository>();//4.age
            services.AddScoped<IAgeServices, AgeServices>();

            services.AddScoped<IDeliveryRepository, DeliveryRepository>();//5.deliv
            services.AddScoped<IDeliveryServices, DeliveryServices>();

            services.AddScoped<IFroleRepository, FroleRepository>();//6.frolr
            services.AddScoped<IFroleServices, FroleServices>();

            services.AddScoped<ISkinRepository, SkinRepository>(); //7.skin
            services.AddScoped<ISkinServices, SkinServices>();

            services.AddScoped<ICategoryRepository, CategoryRepository>(); //8. cat
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IProductColorRepository, ProductColorRepository>(); //8. cat
            services.AddScoped<IProductColorService, ProductColorService>();

            services.AddScoped<IMessageRepository, MessageRepository>(); //9. msg
            services.AddScoped<IMessageService, MessageService>();

            services.AddScoped<IOfferRepository, OfferRepository>(); //10. offer
            services.AddScoped<IOfferService, OfferService>();

            services.AddScoped<IStandaredSizeService, StandaredSizeService>(); //11. size
            services.AddScoped<IStandaredSizeRepository, StandaredSizeRepository>();

            services.AddScoped<IReviewRrepository, ReviewRrepository>(); //12. Review
            services.AddScoped<IReviewService, ReviewService>();

            services.AddScoped<ITestimonialRepository, TestimonialRepository>(); //13. Test
            services.AddScoped<ITestimonialService, TestimonialService>();

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
