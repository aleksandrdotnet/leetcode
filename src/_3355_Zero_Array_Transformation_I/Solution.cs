namespace _3355_Zero_Array_Transformation_I;

public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        foreach (var arr in queries)
        {
            for (var i = arr[0]; i <= arr[1]; i++) nums[i]--;

            if (nums.All(x => x <= 0))
                return true;
        }

        return false;
    }
}

public class Solution2
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var tmp = new int[nums.Length + 1];
        foreach (var arr in queries)
        {
            tmp[arr[0]]++;
            tmp[arr[1] + 1]--;
        }

        var differ = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            differ += tmp[i];
            if (nums[i] > differ)
                return false;
        }

        return true;
    }
}