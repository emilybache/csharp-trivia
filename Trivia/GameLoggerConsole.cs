using System;

namespace Trivia;

public class GameLoggerConsole : IGameLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}