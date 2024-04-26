using DependencyInjectionDotnetCsharp.Interfaces;

namespace DependencyInjectionDotnetCsharp.Services;

public class DieRoller : IDieRoller
{
    private readonly Random _random;

    public DieRoller()
    {
        _random = new Random();
    }

    public int RollDie()
    {
        return _random.Next(1,7);
    }
}