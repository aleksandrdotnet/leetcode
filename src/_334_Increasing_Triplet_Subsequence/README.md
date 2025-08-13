# 334. Increasing Triplet Subsequence

![Complexity](https://img.shields.io/badge/medium-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/greedy-blue)

[334. Increasing Triplet Subsequence](https://leetcode.com/problems/increasing-triplet-subsequence/description/?envType=study-plan-v2&envId=leetcode-75)

```
Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.
```

## Example 1

```
Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
```

## Example 2

```
Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
```

## Constraints

```
1 <= nums.length <= 5 * 10^5
-2^31 <= nums[i] <= 2^31 - 1
```

## Follow up:

Could you implement a solution that runs in O(n) time complexity and O(1) space complexity?

## Code

```csharp
public bool IncreasingTriplet(int[] nums)
{
    if (nums.Length <= 2)
        return false;

    var first = int.MaxValue;
    var mid = int.MaxValue;

    for (var i = 0; i < nums.Length; i++)
    {
        if (mid < nums[i])
            return true;

        if (first > nums[i])
            first = nums[i];
        else
            mid = nums[i];
    }

    return false;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)