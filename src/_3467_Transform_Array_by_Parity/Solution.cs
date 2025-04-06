namespace _3467_Transform_Array_by_Parity;

public class Solution
{
    public int[] TransformArray(int[] nums)
    {
        var result = new int[nums.Length];
        
        var odd = 0;

        foreach (var t in nums)
            if (t % 2 != 0)
                result[nums.Length - ++odd] = 1;

        return result;
    }
}