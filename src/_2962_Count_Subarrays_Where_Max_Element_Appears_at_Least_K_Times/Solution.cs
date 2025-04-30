namespace _2962_Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times;

public class Solution
{
    public long CountSubarrays(int[] nums, long k)
    {
        var result = 0L;
        var count = 0L;

        var max = nums.Max();
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (nums[r] == max)
                count++;

            while (count == k)
                if (nums[l++] == max)
                    count--;

            result += l;
        }

        return result;
    }
}