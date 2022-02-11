
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
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)

        {
            services.AddCors(options =>
            options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));



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

            services.AddScoped<IBuyingRepository, BuyingRepository>(); //8.Buying
            services.AddScoped<IBuyingServices, BuyingServices>();

            services.AddScoped<IOrdersRepository,OredersRepository>(); //8.Buying
            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IUserRepository, UserRepository>(); //8.User
            services.AddScoped<IUserService, UserSrvice>();

            services.AddScoped<ICategoryRepository, CategoryRepository>(); //8. cat
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IProductColorRepository, ProductColorRepository>(); //9. cat
            services.AddScoped<IProductColorService, ProductColorService>();

            services.AddScoped<IMessageRepository, MessageRepository>(); //10. msg
            services.AddScoped<IMessageService, MessageService>();

            services.AddScoped<IOfferRepository, OfferRepository>(); //11. offer
            services.AddScoped<IOfferService, OfferService>();

            services.AddScoped<IStandaredSizeService, StandaredSizeService>(); //12. size
            services.AddScoped<IStandaredSizeRepository, StandaredSizeRepository>();

            services.AddScoped<IReviewRrepository, ReviewRrepository>(); //13. Review
            services.AddScoped<IReviewService, ReviewService>();

            services.AddScoped<ITestimonialRepository, TestimonialRepository>(); //14. Test
            services.AddScoped<ITestimonialService, TestimonialService>();

            services.AddScoped<IAggregationRepository, AggregationRepository>(); //15. Aggregation
            services.AddScoped<IAggregationService, AggregationService> ();//

            services.AddScoped<IMailRepository, MailRepository>(); //15. Aggregation
            services.AddScoped<IMailService, MailService>();//

            services.AddControllers();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
