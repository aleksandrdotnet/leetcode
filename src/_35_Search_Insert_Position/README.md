# 35. Search Insert Position

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/binary_search-blue)

[35. Search Insert Position](https://leetcode.com/problems/search-insert-position/description/)

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return
the index where it would be if it were inserted in order. You must write an algorithm with O(log n) runtime complexity.

## Example 1

```
Input: nums = [1,3,5,6], target = 5
Output: 2
```

## Example 2

```
Input: nums = [1,3,5,6], target = 2
Output: 1
```

## Example 3

```
Input: nums = [1,3,5,6], target = 7
Output: 4
```

## Constraints

> - `1 <= nums.length <= 10^4`
> - `-10^4 <= nums[i] <= 10^4`
> - `nums contains distinct values sorted in ascending order.`
> - `-10^4 <= target <= 10^4`

## Code

```csharp
public int SearchInsert(int[] nums, int target)
{
    var left = 0;
    var right = nums.Length - 1;

    while (left <= right)
    {
        var mid = left + (right - left) / 2;

        if (nums[mid] == target)
            return mid;

        if (nums[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return left;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)