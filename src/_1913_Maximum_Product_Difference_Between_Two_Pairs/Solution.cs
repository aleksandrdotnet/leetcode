namespace _1913_Maximum_Product_Difference_Between_Two_Pairs;

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        var max = new[] { 0, 0 };
        var min = new[] { 10001, 10001 };

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min[0] || nums[i] < min[1])
            {
                if (nums[i] < min[0])
                {
                    min[1] = min[0];
                    min[0] = nums[i];
                }
                else
                {
                    min[1] = nums[i];
                }
            }

            if (nums[i] > max[0] || nums[i] > max[1])
            {
                if (nums[i] > max[0])
                {
                    max[1] = max[0];
                    max[0] = nums[i];
                }
                else
                {
                    max[1] = nums[i];
                }
            }
        }

        return max[0] * max[1] - min[0] * min[1];
    }
}

public class Solution2
{
    public int MaxProductDifference(int[] nums)
    {
        Array.Sort(nums);

        return nums[^2] * nums[^1] - nums[0] * nums[1];
    }
}