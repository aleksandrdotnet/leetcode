namespace _1299_Replace_Elements_with_Greatest_Element_on_Right_Side;

public class Solution
{
    public int[] ReplaceElements2(int[] arr)
    {
        if (arr.Length == 1)
            return [-1];
        if (arr.Length == 2) return [arr[1], -1];

        var result = new int[arr.Length];
        result[arr.Length - 1] = -1;

        var maxIndex = 0;
        while (maxIndex < arr.Length - 1)
        {
            var init = maxIndex;
            var max = -1;
            for (var j = maxIndex + 1; j < arr.Length; j++)
                if (max < arr[j])
                {
                    max = arr[j];
                    maxIndex = j;
                }

            for (var j = init; j < maxIndex; j++) result[j] = arr[maxIndex];
        }

        return result;
    }

    public int[] ReplaceElements(int[] arr)
    {
        if (arr.Length == 1)
            return [-1];
        if (arr.Length == 2) return [arr[1], -1];

        var last = -1;
        for (var i = arr.Length - 1; i >= 0; i--)
            if (arr[i] > last)
                (arr[i], last) = (last, arr[i]);
            else
                arr[i] = last;

        return arr;
    }
}