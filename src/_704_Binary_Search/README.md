# 704. Binary Search

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)

[704. Binary Search](https://leetcode.com/problems/binary-search/)

Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search
target in nums. If target exists, then return its index. Otherwise, return -1. You must write an algorithm with O(log n)
runtime complexity.

## Example 1

```
Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
```

## Example 2

```
Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
```

## Constraints

```
1 <= nums.length <= 10^4
-10^4 < nums[i], target < 10^4
All the integers in nums are unique.
nums is sorted in ascending order.
```

## Code

```csharp
public int Search(int[] nums, int target)
{
    return BinarySearch(nums, target, 0, nums.Length - 1);
}

private int BinarySearch(int[] nums, int target, int left, int right)
{
    if (left > right)
        return -1;

    var mid = left + (right - left) / 2;
    if (nums[mid] == target)
        return mid;
    if (nums[mid] < target)
        return BinarySearch(nums, target, mid + 1, right);
    
    return BinarySearch(nums, target, left, mid - 1);
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)