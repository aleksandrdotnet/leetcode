# 1679. Max Number of K-Sum Pairs

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[1679. Max Number of K-Sum Pairs](https://leetcode.com/problems/max-number-of-k-sum-pairs/description/?envType=study-plan-v2&envId=leetcode-75)

```
You are given an integer array nums and an integer k.

In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

Return the maximum number of operations you can perform on the array.
```

## Example 1
```
Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.
```

## Example 2
```
Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.
```

## Constraints
```
1 <= nums.length <= 10^5
1 <= nums[i] <= 10^9
1 <= k <= 10^9
```

## Code
```csharp
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
```

#Hint:
1. without sorting
2. use dictionary 

## Complexity
> **Time complexity**: O()  
> **Space complexity**: O()