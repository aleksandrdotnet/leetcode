namespace Running;

public static class Solution
{
    public static int[] Run(int[] nums)
    {
        var result = new int[nums.Count()];
        
        result[0] = nums[0];
        for(int i = 1; i < nums.Count(); i++)
            result[i] = result[i-1]+nums[i];

        return result;
    }
}