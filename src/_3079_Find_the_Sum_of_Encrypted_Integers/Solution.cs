namespace _3079_Find_the_Sum_of_Encrypted_Integers;

public static class Solution
{
    private static int Encrypt(int a)
    {
        if (a < 10)
            return a;

        var max = 0;
        var value = a;
        var digits = 0;

        while (value > 0)
        {
            max = Math.Max(max, value % 10);
            digits++;
            value /= 10;
        }

        var result = max;
        for (var i = 0; i < digits - 1; i++)
        {
            result = result * 10 + max;
        }

        return result;
    }

    public static int SumOfEncryptedInt(int[] nums)
    {
        return nums.Sum(Encrypt);
    }
}