using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BouncieNet.Tests
{
    public class IBouncieClientTests
    {
        private IServiceProvider BuildServices()
        {
            // build ServiceCollection
            var services = new ServiceCollection();
            var config = new ConfigurationBuilder()
                .AddUserSecrets("ec68b8c4-2b69-44a7-bba4-0e59d0cb83be")
                .Build();

            services.AddSingleton<IConfiguration>(config);
            services.Configure<BouncieConfiguration>(config.GetSection("BouncieConfig"));
            services.AddBouncieClient();

            return services.BuildServiceProvider();
        }

        [Fact]
        public async Task Test_BouncieNet_Can_GetUser()
        {
            var provider = BuildServices();

            var apiClient = provider.GetRequiredService<IBouncieClient>();
            var result = await apiClient.GetUser();

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
        }

        [Fact]
        public async Task Test_BouncieNet_Can_GetVehicles()
        {
            var provider = BuildServices();

            var apiClient = provider.GetRequiredService<IBouncieClient>();
            var result = await apiClient.GetVehicles(new GetVehiclesRequestParameters() { });

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
        }

        [Fact]
        public async Task Test_BouncieNet_Can_GetTrips()
        {
            var provider = BuildServices();

            var apiClient = provider.GetRequiredService<IBouncieClient>();
            var testImei = provider.GetRequiredService<IConfiguration>().GetValue<string>("TestImei") ?? throw new Exception("Coudl not find test IMEI in configuration. Please ensure it is added to your secrets.json.");
            var result = await apiClient.GetTrips(new GetTripsRequestParameters(testImei) { });

            Assert.Null(result.Error);
            Assert.NotNull(result.Content);
        }
    }
}