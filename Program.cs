using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorStrap;

namespace AnimalToHumanYearsCalculator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<IAnimalsService, AnimalsService>();
            builder.Services.AddBootstrapCss();
            await builder.Build().RunAsync();
        }
    }
}
