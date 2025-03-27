namespace _977_Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var list = nums.Select(x => x * x).ToList();
        list.Sort();
        return list.ToArray();
    }
}