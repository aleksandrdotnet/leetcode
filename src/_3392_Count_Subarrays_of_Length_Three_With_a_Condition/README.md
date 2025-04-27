# 3392. Count Subarrays of Length Three With a Condition

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)

[3392. Count Subarrays of Length Three With a Condition](https://leetcode.com/problems/count-subarrays-of-length-three-with-a-condition/description/?envType=daily-question&envId=2025-04-27)

```
Given an integer array nums, return the number of subarrays of length 3 such that the sum of the first and third numbers equals exactly half of the second number.
```

## Example 1
```
Input: nums = [1,2,1,4,1]
Output: 1
Explanation:  Only the subarray [1,4,1] contains exactly 3 elements where the sum of the first and third numbers equals half the middle number.
```

## Example 2
```
Input: nums = [1,1,1]
Output: 0
Explanation:  [1,1,1] is the only subarray of length 3. However, its first and third numbers do not add to half the middle number.  
```

## Constraints
```
3 <= nums.length <= 100 
-100 <= nums[i] <= 100
```

## Code
```csharp
public int CountSubarrays(int[] nums)
{
    var count = 0;

    for (var i = 0; i + 2 < nums.Length; i++)
        if (nums[i + 1] == 2 * (nums[i] + nums[i + 2]))
            count++;
    
    return count;
}
```

## Complexity
> **Time complexity**: O(n)  
> **Space complexity**: O(1)