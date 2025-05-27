namespace _2894_Divisible_and_Non_divisible_Sums_Difference;

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        var max = n / m;
        return max switch
        {
            0 => n * (n + 1) / 2,
            1 => n * (n + 1) / 2 - 2 * m,
            _ => n * (n + 1) / 2 - m * (max + 1) * max
        };
    }
}