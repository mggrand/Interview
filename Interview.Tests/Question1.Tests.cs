using FluentAssertions;

namespace Interview.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("Hello World!", "!dlroW olleH")]
    [InlineData("step on no pets", "step on no pets")]
    public void Question1_ReverseString_Should_Reverse_InputString(string input, string expected)
    {
        var result = Question1.RevervseString(input);

        result.Should().Be(expected);
    }
}