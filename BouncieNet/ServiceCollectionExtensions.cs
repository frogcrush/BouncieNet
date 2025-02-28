using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace BouncieNet
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBouncieClient(this IServiceCollection services, Action<BouncieConfiguration> configure)
        {
            services.Configure(configure);
            services.AddBouncieClient();
            return services;
        }

        public static IServiceCollection AddBouncieClient(this IServiceCollection services)
        {
            services.AddSingleton<BouncieStaticAuthHeaderHandler>();
            services.AddRefitClient<IBouncieClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.bouncie.dev"))
                .AddHttpMessageHandler<BouncieStaticAuthHeaderHandler>();
            return services;
        }
    }
}