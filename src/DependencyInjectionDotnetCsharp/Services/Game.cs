using DependencyInjectionDotnetCsharp.Interfaces;

namespace DependencyInjectionDotnetCsharp.Services;

public class Game
{
    private readonly IDieRoller _dieRoller;

    public Game(IDieRoller dieRoller)
    {
        _dieRoller = dieRoller;
    }

    public void Play()
    {
        Console.WriteLine($"Die roll: {_dieRoller.RollDie()}");
    }
}