﻿namespace _75_Sort_Colors;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 0, 2, 1, 1, 0 }, new[] { 0, 0, 1, 1, 2, 2 })]
    [InlineData(new[] { 2, 0, 1 }, new[] { 0, 1, 2 })]
    public void Run(int[] nums, int[] expected)
    {
        new Solution().SortColors(nums);
        Assert.Equal(expected, nums);
    }
}