using Br.Com.Restaurant.Business.Interfaces;
using Br.Com.Restaurant.Business.Services;
using Br.Com.Restaurant.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Br.Com.Restaurant.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
