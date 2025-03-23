# 905. Sort Array By Parity

![Complexity](https://img.shields.io/badge/easy-green) ![Topics](https://img.shields.io/badge/array-blue) ![Topics](https://img.shields.io/badge/two_pointers-blue) ![Topics](https://img.shields.io/badge/sorting-blue)

[905. Sort Array By Parity](https://leetcode.com/problems/sort-array-by-parity/description/)

Given an integer array `nums`, move all the even integers at the beginning of the array followed by all the odd integers.
Return any array that satisfies this condition.

## Example 1
> **Input**: `nums = [3,1,2,4]`  
> **Output**: `[2,4,3,1]`  
> **Explanation**: `The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.`

## Example 2
> **Input**: `nums = [0]`  
> **Output**: `[0]`

## Constraints
> - `1 <= nums.length <= 5000`  
> - `0 <= nums[i] <= 5000`

## Code
```csharp
public int[] SortArrayByParity(int[] input)
{
    var writePointer = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % 2 == 0)
        {
            (input[i], input[writePointer]) = (input[writePointer], input[i]);
            writePointer++;
        }
    }
    
    return input;
}
```

## Complexity
> **Time complexity**: O(n)  
> **Space complexity**: O(1)