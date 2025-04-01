namespace _2206_Divide_Array_Into_Equal_Pairs;

public class Solution
{
    public bool DivideArray(int[] nums)
    {
        if (nums.Length % 2 != 0)
            return false;

        var dict = new Dictionary<int, int>();
        foreach (var n in nums)
            if (!dict.TryAdd(n, 1))
                dict[n]++;

        return dict.All(x => x.Value % 2 == 0);
    }
}