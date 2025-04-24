using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;
using System.IO;
using Trivia;

public class GameRunnerApprovalTests
{
    [Fact]
    [UseReporter(typeof(WinMergeReporter))]
    public void GameRunner_Output_Should_Be_Approved()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        GameRunner.Main(new string[] { });

        // Assert
        Approvals.Verify(output.ToString());
    }
}