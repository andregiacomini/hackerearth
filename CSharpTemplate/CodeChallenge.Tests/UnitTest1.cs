using Xunit;

namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string[] input = System.IO.File.ReadAllLines("testInput.txt");
        string[] output = System.IO.File.ReadAllLines("testOutput.txt");
        Assert.Equal(output,Solution.Execute(input));
    }
}