using FluentAssertions;

namespace Interview.Tests;

public class Questions_1_Basic_Tests
{
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("Hello World!", "!dlroW olleH")]
    [InlineData("step on no pets", "step on no pets")]
    public void ReverseString_Should_Reverse_InputString(string input, string expected)
    {
        var result = Questions_1_Basic.RevervseString(input);

        result.Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(CharData))]
    public void CharCount_Should_Count_Each_Char(string input, Dictionary<char, int> expected)
    {
        var result = Questions_1_Basic.CharCount(input);

        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> CharData =>
        [
            ["Hello", new Dictionary<char, int>() { { 'h', 1 }, { 'e', 1 }, { 'l', 2 }, { 'o', 1 }, }],
            ["Starkes Team", new Dictionary<char, int>() { { 's', 2 }, { 't', 2 }, { 'a', 2 }, { 'r', 1 }, { 'k', 1 }, { 'e', 2 }, { 'm', 1 }, }],
        ];
    
}