namespace _905_Sort_Array_By_Parity;

public class Solution
{
    public int[] SortArrayByParity(int[] input)
    {
        var writePointer = 0;
        for (var i = 0; i < input.Length; i++)
            if (input[i] % 2 == 0)
            {
                (input[i], input[writePointer]) = (input[writePointer], input[i]);
                writePointer++;
            }

        return input;
    }
}