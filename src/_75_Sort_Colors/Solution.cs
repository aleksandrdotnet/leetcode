namespace _75_Sort_Colors;

public class Solution
{
    public void SortColors(int[] nums)
    {
        MergeSort(nums);
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

class Solution2
{
    public void SortColors(int[] nums)
    {
        var ns = MergeSort(nums);
        for (var index = 0; index < ns.Length; index++)
            nums[index] = ns[index];
    }

    private int[] MergeSort(int[] array)
    {
        return array.Length < 2
            ? array
            : Merge(MergeSort(array[..(array.Length / 2)]), MergeSort(array[(array.Length / 2)..]));
    }

    private int[] Merge(int[] left, int[] right)
    {
        return left.Concat(right).OrderBy(x => x).ToArray();
    }
}

class Solution3
{
    public void SortColors(int[] nums)
    {
        BubbleSort(nums);
    }

    private void BubbleSort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = i + 1; j < array.Length; j++)
            {
                if(array[i] > array[j])
                    (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
}