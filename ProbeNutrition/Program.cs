using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MudBlazor.Services;
using BusinessLogic;
using Application.Data;

namespace ProbeNutrition
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<Calculation>();
            builder.Services.AddSingleton<CalculatedValues>();
            builder.Services.AddSingleton<InputValues>();
            builder.Services.AddSingleton<ProbeType>();

            await builder.Build().RunAsync();
        }
    }
}
