namespace _1679_Max_Number_of_K_Sum_Pairs;

public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        MergeSort(nums);
        var left = 0;
        var right = nums.Length - 1;
        var result = 0;

        while (left < right)
        {
            if (nums[left] == 0)
            {
                left++;
                continue;
            }

            if (nums[right] == 0)
            {
                right--;
                continue;
            }

            if (nums[left] + nums[right] > k)
            {
                right--;
            }
            else if (nums[left] + nums[right] < k)
            {
                left++;
            }
            else
            {
                nums[left] = 0;
                nums[right] = 0;
                result++;
            }
        }

        return result;
    }

    private void MergeSort(int[] array)
    {
        var temp = new int[array.Length];
        MergeSort(array, temp, 0, array.Length - 1);
    }

    private void MergeSort(int[] array, int[] temp, int left, int right)
    {
        if (left >= right)
            return;

        var mid = left + (right - left) / 2;

        MergeSort(array, temp, left, mid);
        MergeSort(array, temp, mid + 1, right);

        Merge(array, temp, left, mid, right);
    }

    private void Merge(int[] array, int[] temp, int left, int mid, int right)
    {
        int i = left, j = mid + 1, k = left;

        while (i <= mid && j <= right)
            if (array[i] <= array[j])
                temp[k++] = array[i++];
            else
                temp[k++] = array[j++];

        while (i <= mid)
            temp[k++] = array[i++];

        while (j <= right)
            temp[k++] = array[j++];

        for (var x = left; x <= right; x++)
            array[x] = temp[x];
    }
}