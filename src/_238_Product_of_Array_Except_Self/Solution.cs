namespace _238_Product_of_Array_Except_Self;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        Array.Fill(result, 1);

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length; j++)
            {
                if(i != j)
                    result[i] *= nums[j];
            }
        }
        
        return result;
    }
}

public class Solution2
{
    //B   1  2  3  4
    //R  24 12  8  6 
    
    //P   1  2  6 24
    //S  24 24 12  4
    
    //--------------
    
    //B   1   2   3   4   5
    //R 120  60  40  30  24
    
    //P   1   2   6  24 120
    //S 120 120  60  20   5 
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        
        prefix[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
            prefix[i] = prefix[i - 1] * nums[i];
        
        suffix[^1] = nums[^1];
        for (var i = nums.Length - 2; i >= 0; i--)
            suffix[i] = suffix[i + 1] * nums[i];

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
                result[i] = suffix[i+1];
            else if(i == nums.Length - 1)
                result[i] = prefix[i-1];
            else
                result[i] = prefix[i-1] * suffix[i+1];
        }
        
        return result;
    }
}