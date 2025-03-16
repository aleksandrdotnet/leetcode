# 1480. Running Sum of 1d Array

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/prefix_sum-blue)

[1480. Running Sum of 1d Array](https://leetcode.com/problems/running-sum-of-1d-array)

Given an array `nums`. We define a running sum of an array as `runningSum[i] = sum(nums[0]…nums[i])`.

Return the running sum of `nums`.

## Example 1

> **Input**: nums = [1,2,3,4]  
> **Output**: [1,3,6,10]  
> **Explanation**: Running sum is obtained as follows: `[1, 1+2, 1+2+3, 1+2+3+4]`.

## Example 2

> **Input**: nums = `[1,1,1,1,1]`  
> **Output**: `[1,2,3,4,5]`  
> **Explanation**: Running sum is obtained as follows: `[1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1]`.

## Example 3

> **Input**: nums = `[3,1,2,10,1]`  
> **Output**: `[3,4,6,16,17]`

## Constraints

> `1 <= nums.length <= 1000`  
> `-10^6 <= nums[i] <= 10^6`

## Code

```csharp
public static int[] Run(int[] input)
{
    var result = new int[input.Length];

    result[0] = input[0];
    for (var i = 1; i < input.Length; i++)
        result[i] = result[i - 1] + input[i];

    return result;
}
```