namespace _643_Maximum_Average_Subarray_I;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var sum = nums[..k].Sum();
        var max = sum;

        for (var right = k; right < nums.Length; right++)
        {
            sum += nums[right] - nums[right - k];

            max = Math.Max(max, sum);
        }

        return (double)max / k;
    }
}