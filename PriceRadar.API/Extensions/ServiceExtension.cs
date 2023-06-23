using Microsoft.EntityFrameworkCore;
using PriceRadar.Application;
using PriceRadar.Application.Interfaces;
using PriceRadar.Application.Services;
using PriceRadar.Core.Interfaces;
using PriceRadar.Core.Repositories;
using PriceRadar.Infrastructure.Data;
using PriceRadar.Infrastructure.Logging;
using PriceRadar.Infrastructure.Repositories;

namespace PriceRadar.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCorsAllowAny(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "Price Radar API", Version = "v1" });
            });
        }

        public static void AddLayerForApp(this WebApplicationBuilder builder)
        {
            // Add Infrastructure Layer
            builder.Services.AddDbContext<YourNewsDbContext>(c =>
                c.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            // Add Application Layer
            builder.Services.AddScoped<IProductService, ProductService>();

            // Add Web Layer
            builder.Services.AddAutoMapper(typeof(ModelMappingProfiles));
            builder.Services.AddAutoMapper(typeof(DtoMappingProfile));
        }
    }
}
