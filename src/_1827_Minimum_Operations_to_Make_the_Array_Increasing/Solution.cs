namespace _1827_Minimum_Operations_to_Make_the_Array_Increasing;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var result = 0;

        if (nums.Length == 1)
            return result;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
                continue;

            var offset = nums[i] - nums[i + 1] + 1;
            nums[i + 1] += offset;
            result += offset;
        }

        return result;
    }
}