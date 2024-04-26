using DependencyInjectionDotnetCsharp.Interfaces;
using DependencyInjectionDotnetCsharp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionDotnetCsharp;

class Program
{
    static void Main(string[] args)
    {
        using var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddTransient<IDieRoller, DieRoller>();
                services.AddTransient<Game>();
            })
            .Build();

        var game = host.Services.GetRequiredService<Game>();
        game.Play();
    }
}
