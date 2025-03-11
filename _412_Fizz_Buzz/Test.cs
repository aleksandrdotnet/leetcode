using FluentAssertions;

namespace _412_Fizz_Buzz;

public class Test
{
    [Theory]
    [InlineData(3, new[] { "1", "2", "Fizz" })]
    [InlineData(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15,
        new[]
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
        })]
    public void Run(int input, string[] output)
    {
        var result = Solution.Run(input);

        output.Should().BeEquivalentTo(result, options => options.WithoutStrictOrdering());
    }
}