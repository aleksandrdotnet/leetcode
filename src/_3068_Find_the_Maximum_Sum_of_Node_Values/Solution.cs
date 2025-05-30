namespace _3068_Find_the_Maximum_Sum_of_Node_Values;

public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long totalSum = 0;
        var xorBenefitCount = 0;
        var minLoss = int.MaxValue;

        foreach (var num in nums)
        {
            var xorValue = num ^ k;
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

        if (xorBenefitCount % 2 == 1) totalSum -= minLoss;

        return totalSum;
    }
}

public class Solution2
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long sum = 0;
        var minGain = int.MaxValue;
        var minLoss = int.MaxValue;
        var evenGains = true;
        foreach (var v in nums)
        {
            var xor = v ^ k;
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