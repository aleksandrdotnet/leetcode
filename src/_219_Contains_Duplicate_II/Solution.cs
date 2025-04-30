namespace _219_Contains_Duplicate_II;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var result = false;
        for (var l = 0; l < nums.Length; l++)
        for (var r = l + 1; r < nums.Length; r++)
        {
            if (nums[r] != nums[l])
                continue;

            if (Math.Abs(r - l) <= k)
                result = true;
        }

        return result;
    }
}

public class Solution2
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var right = 0; right < nums.Length; right++)
        {
            if (dict.TryGetValue(nums[right], out var left))
                if (right - left <= k)
                    return true;

            dict[nums[right]] = right;
        }

        return false;
    }
}