namespace _2427_Number_of_Common_Factors;

public class Solution
{
    public int CommonFactors(int a, int b)
    {
        var result = 1 + (a == b && a > 1 ? 1 : 0);
        var m = Math.Min(Math.Min(a, b), Math.Max(a, b) / 2);

        for (var i = 2; i <= m; i++)
            if (a % i == 0 && b % i == 0)
                result++;

        return result;
    }
}