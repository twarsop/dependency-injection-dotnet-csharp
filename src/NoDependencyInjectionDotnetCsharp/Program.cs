using NoDependencyInjectionDotnetCsharp.Services;

namespace NoDependencyInjectionDotnetCsharp;

class Program
{
    static void Main(string[] args)
    {
        var game = new Game();
        game.Play();
    }
}
