# 217. Contains Duplicate

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[217. Contains Duplicate](https://leetcode.com/problems/contains-duplicate/)

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every
element is distinct.

## Example 1

> **Input**: `nums = [1,2,3,1]`  
> **Output**: `true`  
> **Explanation**: `The element 1 occurs at the indices 0 and 3.`

## Example 2

> **Input**: `nums = [1,2,3,4]`  
> **Output**: `false`  
> **Explanation**: `All elements are distinct.`
>

## Example 2

> **Input**: `nums = [1,1,1,3,3,4,3,2,4,2]`  
> **Output**: true

## Constraints

> - `1 <= nums.length <= 10^5`
> - `-10^9 <= nums[i] <= 10^9`

## Code

```csharp
public bool ContainsDuplicate(int[] nums)
{
    Dictionary<int, bool> dict = new(nums.Length);
    foreach (var el in nums)
    {
        if (!dict.TryAdd(el, true))
            return true;
    }
    return false;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)