namespace _2302_Count_Subarrays_With_Score_Less_Than_K;

public class Solution
{
    public long CountSubarrays(int[] nums, long k)
    {
        var result = 0L;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= k)
                continue;
            
            result++;

            for (var j = i + 1; j < nums.Length; j++)
            {
                var subsum = nums[i..(j + 1)].Sum();
                if (subsum * (j - i + 1) >= k)
                    break;
                
                result++;
            }
        }
        
        return result;
    }
}

public class Solution2
{
    public long CountSubarrays(int[] nums, long k)
    {
        var result = 0L;
        var sum = 0L;
        
        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum * (right - left + 1) >= k)
                sum -= nums[left++];

            result += right - left + 1;
        }

        return result;
    }
}