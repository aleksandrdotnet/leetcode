# 977. Squares of a Sorted Array

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[977. Squares of a Sorted Array](https://leetcode.com/problems/squares-of-a-sorted-array/description/)

Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in
non-decreasing order.

## Example 1

> **Input**: `nums = [-4,-1,0,3,10]`  
> **Output**: `[0,1,9,16,100]`  
> **Explanation**: After squaring, the array becomes [16,1,0,9,100].
> After sorting, it becomes [0,1,9,16,100].

## Example 2

> **Input**: `nums = [-7,-3,2,3,11]`  
> **Output**: `[4,9,9,49,121]`

## Constraints

> - `1 <= nums.length <= 10^4`
> - `-10^4 <= nums[i] <= 10^4`
> - `nums is sorted in non-decreasing order.`

## Code

```csharp
public int[] SortedSquares(int[] nums)
{
    var list = nums.Select(x => x * x).ToList();
    list.Sort();
    return list.ToArray();
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)

## Idea

> `Think about Constraints and data`

## Hint

> `The sequence is increasing. first element > last element.`
> `Use Math.Abs`