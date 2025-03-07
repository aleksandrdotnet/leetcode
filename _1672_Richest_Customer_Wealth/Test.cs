using FluentAssertions;

namespace _1672_Richest_Customer_Wealth;

public class Test
{
    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } },
            6
        ];
        yield return
        [
            new[] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } },
            10
        ];
        yield return
        [
            new[] { new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } },
            17
        ];
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void Run(int[][] input, int output)
    {
        var result = Solution.Run(input);

        output.Should().Be(result);
    }
}