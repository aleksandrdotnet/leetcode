# 75. Sort Colors

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[75. Sort Colors ](https://leetcode.com/problems/sort-colors/description/)

Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are
adjacent, with the colors in the order red, white, and blue. We will use the integers 0, 1, and 2 to represent the color
red, white, and blue, respectively. You must solve this problem without using the library's sort function.

## Example 1

> **Input**: `nums = [2,0,2,1,1,0]`  
> **Output**: `[0,0,1,1,2,2]`

## Example 2

> **Input**: `nums = [2,0,1]`  
> **Output**: `[0,1,2]`

## Constraints

> - `n == nums.length`
> - `1 <= n <= 300`
> - `nums[i] is either 0, 1, or 2`

## Code

### Merge Sort #1

```csharp
public class Solution {
    public void SortColors(int[] nums) 
    {
        var temp = new int[nums.Length];
        MergeSort(nums, temp, 0, nums.Length-1);
    }

    private void MergeSort(int[] arr, int[] tmp, int left, int right)
    {
        if(left >= right)
            return;

        var mid = left + (right - left)/2;

        MergeSort(arr, tmp, left, mid);
        MergeSort(arr, tmp, mid + 1, right);

        Merge(arr, tmp, left, mid, right);
    }

    private void Merge(int[] arr, int[] tmp, int left, int mid, int right)
    {
        var i = left;
        var j = mid + 1;
        var k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                tmp[k] = arr[i];
                k++;
                i++;
            }
            else
            {
                tmp[k] = arr[j];
                k++;
                j++;
            }
        }

        while (i <= mid)
        {
            tmp[k] = arr[i];
            k++;
            i++;
        }

        while (j <= right)
        {
            tmp[k] = arr[j];
            k++;
            j++;
        }

        for (i = left; i <= right; i++)
        {
            arr[i] = tmp[i];
        }
    }
}
```

### Merge Sort #2

```csharp
public void SortColors2(int[] nums)
{
    var ns = MergeSort2(nums);
    for (var index = 0; index < ns.Length; index++)
        nums[index] = ns[index];
}

private int[] MergeSort2(int[] array) =>
    array.Length < 2 ? array : Merge2(MergeSort2(array[..(array.Length / 2)]), MergeSort2(array[(array.Length / 2)..]));

private int[] Merge2(int[] left, int[] right) =>
    left.Concat(right).OrderBy(x => x).ToArray();
```

## Complexity

> **Time complexity**: O(nlogn)  
> **Space complexity**: O(n)