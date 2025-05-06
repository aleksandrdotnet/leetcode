namespace _1920_Build_Array_from_Permutation;

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            result[i] = nums[nums[i]];

        return result;
    }
}