namespace _2563_Count_the_Number_of_Fair_Pairs;

public class Solution
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (lower <= nums[i] + nums[j] && nums[i] + nums[j] <= upper)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

public class Solution2
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        return CountPairs(nums, upper) - CountPairs(nums, lower - 1);
    }

    private long CountPairs(int[] nums, int target)
    {
        long count = 0;
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] > target) right--;
            else
            {
                count += right - left;
                left++;
            }
        }

        return count;
    }
}