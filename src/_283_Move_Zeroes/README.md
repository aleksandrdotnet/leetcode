# 283. Move Zeroes

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/two_pointers-blue)

[283. Move Zeroes](https://leetcode.com/problems/move-zeroes/description/)

Given an integer array `nums`, move all `0`'s to the end of it while maintaining the relative order of the non-zero
elements.
Note that you must do this in-place without making a copy of the array.

## Example 1

> **Input**: `nums = [0,1,0,3,12]`  
> **Output**: `[1,3,12,0,0]`

## Example 2

> **Input**: `nums = [0]`  
> **Output**: `[0]`

## Constraints

> - `1 <= nums.length <= 10^4`
> - `-2^31 <= nums[i] <= 2^31 - 1`

## Code

```csharp
public void MoveZeroes(int[] nums)
{
    var writePointer = 0;
    for(var readPointer = 0; readPointer < nums.Length; readPointer++)
    {
        if(nums[readPointer] != 0)
        {
            (nums[writePointer], nums[readPointer]) = (nums[readPointer], nums[writePointer]);
            writePointer++;
        }
    }
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)