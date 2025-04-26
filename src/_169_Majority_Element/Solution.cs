namespace _169_Majority_Element;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var limit = nums.Length / 2;
        var dict = new Dictionary<int, int>();

        foreach (var number in nums)
            if (dict.TryGetValue(number, out var count))
            {
                if (count + 1 > limit)
                    return number;

                dict[number] = count + 1;
            }
            else
            {
                dict[number] = 1;
            }

        return dict[0];
    }
}

public class Solution2
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0, count = 0;

        foreach (var num in nums)
        {
            if (count == 0) candidate = num;

            count += num == candidate ? 1 : -1;
        }

        return candidate;
    }
}