namespace NoDependencyInjectionDotnetCsharp.Services;

public class Game
{
    private readonly DieRoller _dieRoller;

    public Game()
    {
        _dieRoller = new DieRoller();
    }

    public void Play()
    {
        Console.WriteLine($"Die roll: {_dieRoller.RollDie()}");
    }
}