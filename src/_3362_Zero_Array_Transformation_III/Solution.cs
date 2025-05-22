namespace _3362_Zero_Array_Transformation_III;

public class Solution
{
    public int MaxRemoval(int[] nums, int[][] queries)
    {
        Array.Sort(queries, (a, b) => a[0] - b[0]);
        var heap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        int[] deltaArray = new int[nums.Length + 1];
        int operations = 0;

        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            operations += deltaArray[i];
            while (j < queries.Length && queries[j][0] == i)
            {
                heap.Enqueue(queries[j][1], queries[j][1]);
                j++;
            }

            while (operations < nums[i] && heap.Count > 0 && heap.Peek() >= i)
            {
                operations += 1;
                deltaArray[heap.Dequeue() + 1] -= 1;
            }

            if (operations < nums[i])
            {
                return -1;
            }
        }

        return heap.Count;
    }

    // public int MaxRemoval(int[] nums, int[][] queries)
    // {
    //     MergeSort(queries);
    //     
    //     var minHeap = new PriorityQueue<
    //     
    //     return -1;
    // }

    private void MergeSort(int[][] nums)
    {
        var tmp = new int[nums.Length][];
        
        MergeSortInternal(nums, tmp, 0, nums.Length - 1);
    }

    private void MergeSortInternal(int[][] nums, int[][] tmp, int left, int right)
    {
        if (left >= right)
            return;
        
        var mid = left + (right - left) / 2;
        MergeSortInternal(nums, tmp, left, mid);
        MergeSortInternal(nums, tmp, mid + 1, right);
        
        MergeInternal(nums, tmp, left, mid, right);
    }

    private void MergeInternal(int[][] nums, int[][] tmp, int left, int mid, int right)
    {
        var i = left;
        var j = mid + 1;
        var k = left;

        while (i <= mid && j <= right)
        {
            var l = nums[i][1] - nums[i][0];
            var r = nums[j][1] - nums[j][0];
            if (l <= r)
            {
                tmp[k] = nums[j];
                k++;
                j++;
            }
            else
            {
                tmp[k] = nums[i];
                k++;
                i++;
            }
        }

        while (i <= mid)
        {
            tmp[k] = nums[i];
            k++;
            i++;
        }

        while (j <= right)
        {
            tmp[k] = nums[j];
            k++;
            j++;
        }

        for (i = left; i <= right; i++)
        {
            nums[i] = tmp[i];
        }
    }
}