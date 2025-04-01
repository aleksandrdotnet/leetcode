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
public void SortColors(int[] nums)
{
    MergeSort(nums);
}

private void MergeSort(int[] array)
{
    int[] temp = new int[array.Length];
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
    {
        if (array[i] <= array[j])
            temp[k++] = array[i++];
        else
            temp[k++] = array[j++];
    }

    while (i <= mid)
        temp[k++] = array[i++];

    while (j <= right)
        temp[k++] = array[j++];
        
    for (var x = left; x <= right; x++)
        array[x] = temp[x];
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

> **Time complexity**: O()  
> **Space complexity**: O()