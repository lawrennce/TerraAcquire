using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Security.Claims;
using TerraAquire.Contracts;


namespace  TerraAquire.Services.Common
{

    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddMemoryCache();
            //services.AddHttpContextAccessor();

            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(p => typeof(IService).IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);

            foreach (var type in types)
            {
                var typeInterface = type.GetInterface($"I{type.Name}");

                if (typeInterface == null)
                    continue;

                services.AddScoped(typeInterface, type);
            }
        }
    }
}