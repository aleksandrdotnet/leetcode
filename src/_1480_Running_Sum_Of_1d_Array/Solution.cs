namespace _1480_Running_Sum_Of_1d_Array;

public static class Solution
{
    public static int[] Run(int[] input)
    {
        var result = new int[input.Length];

        result[0] = input[0];
        for (var i = 1; i < input.Length; i++)
            result[i] = result[i - 1] + input[i];

        return result;
    }
}