namespace _448_Find_All_Numbers_Disappeared_in_an_Array;

public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var hs = new HashSet<int>(nums);
        var result = new List<int>();

        for (var i = 1; i <= nums.Length; i++)
            if (!hs.Contains(i))
                result.Add(i);

        return result;
    }
}