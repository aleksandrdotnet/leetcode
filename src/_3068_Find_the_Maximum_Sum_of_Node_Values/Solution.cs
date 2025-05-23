namespace _3068_Find_the_Maximum_Sum_of_Node_Values;

public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long totalSum = 0;
        int xorBenefitCount = 0;
        int minLoss = int.MaxValue;

        foreach (int num in nums)
        {
            int xorValue = num ^ k;
            totalSum += Math.Max(num, xorValue);

            if (xorValue > num)
            {
                xorBenefitCount++;
                minLoss = Math.Min(minLoss, xorValue - num);
            }
            else
            {
                minLoss = Math.Min(minLoss, num - xorValue);
            }
        }

        if (xorBenefitCount % 2 == 1)
        {
            totalSum -= minLoss;
        }

        return totalSum;
    }
}

public class Solution2
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long sum = 0;
        int minGain = int.MaxValue;
        int minLoss = int.MaxValue;
        bool evenGains = true;
        foreach (int v in nums)
        {
            int xor = v ^ k;
            if (xor > v)
            {
                sum += xor;
                evenGains = !evenGains;
                minGain = Math.Min(minGain, xor - v);
            }
            else
            {
                sum += v;
                minLoss = Math.Min(minLoss, v - xor);
            }
        }

        if (!evenGains)
            sum = Math.Max(sum - minGain, sum - minLoss);
        return sum;
    }
}