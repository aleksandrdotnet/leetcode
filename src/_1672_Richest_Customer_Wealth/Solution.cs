namespace _1672_Richest_Customer_Wealth;

public static class Solution
{
    public static int Run(int[][] input)
    {
        var max = input[0].Sum();

        for (var i = 1; i < input.Length; i++)
        {
            var calcMax = input[i].Sum();
            if (calcMax > max)
                max = calcMax;
        }

        return max;
    }
}