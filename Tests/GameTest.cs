using System;
using System.Collections.Generic;
using Trivia;
using Xunit;
using Xunit.Sdk;

namespace Tests;


public class GameTest : IGameLogger
{
    private readonly List<string> _loggedMessages = new();
    
    [Fact]
    public void Game_OnCorrectAnswerNoPenalty_ShouldLogCorrectAnswer()
    {
        var game =  new Game(this);
        game.Add("Alice");
        game.WasCorrectlyAnswered();
        Assert.True(HasMessage("Answer was correct!!!!"));
    }

    public bool HasMessage(string message)
    {
        return _loggedMessages.Contains(message);
    }

    public void Log(string message)
    {
        _loggedMessages.Add(message);
    }
}