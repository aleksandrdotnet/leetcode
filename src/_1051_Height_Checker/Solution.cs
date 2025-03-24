namespace _1051_Height_Checker;

public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var expected = (int[])heights.Clone();
        Array.Sort(heights);

        var result = 0;
        for (var i = 0; i < expected.Length; i++)
        {
            if (expected[i] != heights[i])
                result++;
        }

        return result;
    }
}