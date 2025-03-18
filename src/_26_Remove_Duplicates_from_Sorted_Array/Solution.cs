namespace _26_Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        var j = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[j] != nums[i])
                nums[++j] = nums[i];

        return j + 1;
    }
}