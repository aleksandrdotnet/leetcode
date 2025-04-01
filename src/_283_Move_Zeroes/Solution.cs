namespace _283_Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var writePointer = 0;
        for (var readPointer = 0; readPointer < nums.Length; readPointer++)
            if (nums[readPointer] != 0)
            {
                (nums[writePointer], nums[readPointer]) = (nums[readPointer], nums[writePointer]);
                writePointer++;
            }
    }
}