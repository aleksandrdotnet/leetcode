namespace _35_Search_Insert_Position;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var mid = nums.Length / 2;
        var value = nums[mid];
        
        if(value > target)
            return SearchInsertExternal(nums, target, 0, mid);

        return SearchInsertExternal(nums, target, mid,nums.Length - 1);
    }

    private int SearchInsertExternal(int[] nums, int target, int min, int max)
    {
        var mid = min + (max - min) / 2;
        var value = nums[mid];

        if (value == target)
            return mid;
        if (mid == min && value < target)
            return 1 + min;
        if(max == mid && value < target)
            return 1 + max;
        
        if(value > target)
            return SearchInsertExternal(nums, target, min, mid);

        return SearchInsertExternal(nums, target, mid, max);
    }
}