using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;
using System.IO;
using System;
using Trivia;


public class GameRunnerApprovalTests
{
    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void GameRunner_Seeded_Random_Characterization_Test()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        GameRunner.Main(new string[] { "36" });

        // Assert
        Approvals.Verify(output.ToString());
    }

    [Fact]
    [UseReporter(typeof(DiffReporter))]
    public void GameRunner_Manual_Characterization_Test()
    {
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        var aGame = new Game();

        aGame.Add("Chet");
        aGame.Add("Pat");
        aGame.Add("Sue");

        aGame.Roll(4);
        aGame.WrongAnswer();
        aGame.Roll(3);
        aGame.WasCorrectlyAnswered();
        aGame.Roll(1);
        aGame.WrongAnswer();
        aGame.Roll(6);
        aGame.WasCorrectlyAnswered();
        aGame.Roll(4);
        aGame.WrongAnswer();
        aGame.Roll(2);
        aGame.WasCorrectlyAnswered();
        aGame.Roll(1);
        aGame.WrongAnswer();
        aGame.Roll(3);
        aGame.WasCorrectlyAnswered();
        
        // Assert
        Approvals.Verify(output.ToString());
    }
    
}