namespace _217_Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, bool> dict = new(nums.Length);
        foreach (var el in nums)
            if (!dict.TryAdd(el, true))
                return true;
        return false;
    }
}