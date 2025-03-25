namespace _414_Third_Maximum_Number;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        switch (nums.Length)
        {
            case 1:
                return nums[0];
            case 2:
                return nums[0] < nums[1] ? nums[1] : nums[0];
        }

        Array.Sort(nums, (a, b) => a.CompareTo(b));

        var superMax = nums[^1];
        var count = 1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i+1] > nums[i])
            {
                count++;
                if(count > 2)
                    return nums[i];
            }
        }

        return superMax;
    }
}