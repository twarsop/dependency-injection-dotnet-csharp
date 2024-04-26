namespace NoDependencyInjectionDotnetCsharp.Services;

public class DieRoller
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