namespace _704_Binary_Search;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int left, int right)
    {
        if (left > right)
            return -1;

        var mid = left + (right - left) / 2;
        if (nums[mid] == target)
            return mid;
        if (nums[mid] < target)
            return BinarySearch(nums, target, mid + 1, right);

        return BinarySearch(nums, target, left, mid - 1);
    }
}