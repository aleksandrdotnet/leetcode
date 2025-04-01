# 448. Find All Numbers Disappeared in an Array

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)

[448. Find All Numbers Disappeared in an Array](https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/)

Given an array nums of n integers where `nums[i]` is in the range `[1, n]`, return an array of all the integers in the
range `[1, n]` that do not appear in nums.

## Example 1

> **Input**: `nums = [4,3,2,7,8,2,3,1]`  
> **Output**: `[5,6]`

## Example 2

> **Input**: `nums = [1,1]`  
> **Output**: [2]

## Constraints

> - `n == nums.length`
> - `1 <= n <= 10^5`
> - `1 <= nums[i] <= n`

## Code

```csharp
public IList<int> FindDisappearedNumbers(int[] nums)
{
    var hs = new HashSet<int>(nums);
    var result = new List<int>();

    for (var i = 1; i <= nums.Length; i++)
        if (!hs.Contains(i))
            result.Add(i);

    return result;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)