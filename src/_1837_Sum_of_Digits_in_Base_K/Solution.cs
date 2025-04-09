namespace _1837_Sum_of_Digits_in_Base_K;

public class Solution
{
    public int SumBase(int n, int k)
    {
        var next = n / k;
        var result = n % k;

        while (next >= k)
        {
            result += next % k;
            next = next / k;
        }

        return result + next;
    }
}