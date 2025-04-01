namespace _941_Valid_Mountain_Array;

public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) return false;

        var peak = 0;
        for (var i = 1; i < arr.Length; i++)
            if (arr[i - 1] < arr[i])
                peak = i;
            else
                break;

        if (peak == 0 || peak == arr.Length - 1) return false;

        for (var j = peak + 1; j < arr.Length; j++)
            if (arr[j - 1] <= arr[j])
                return false;

        return true;
    }

    public bool ValidMountainArray2(int[] arr)
    {
        if (arr.Length < 3)
            return false;

        var left = 0;
        var right = arr.Length - 1;

        while (left < right && left + 1 < arr.Length && right - 1 > 0)
        {
            var change = false;

            if (arr[left] == arr[left + 1] || arr[right] == arr[right - 1])
                return false;

            if (arr[left] < arr[left + 1])
            {
                left++;
                change = true;
            }

            if (arr[right - 1] > arr[right])
            {
                right--;
                change = true;
            }

            if (!change)
                return false;
        }

        return left == right && left != 0 && right != arr.Length - 1;
    }
}