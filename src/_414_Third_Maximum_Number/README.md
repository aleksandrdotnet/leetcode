# 414. Third Maximum Number

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[414. Third Maximum Number](https://leetcode.com/problems/third-maximum-number/)

Given an integer array `nums`, return the third distinct maximum number in this array. If the third maximum does not
exist, return the maximum number.

## Example 1

> **Input**: `nums = [3,2,1]`  
> **Output**: `1`  
> **Explanation**:  
> The first distinct maximum is 3.  
> The second distinct maximum is 2.  
> The third distinct maximum is 1.

## Example 2

> **Input**: `nums = [1,2]`  
> **Output**: `2`  
> **Explanation**:  
> The first distinct maximum is 2.  
> The second distinct maximum is 1.  
> The third distinct maximum does not exist, so the maximum (2) is returned instead.

## Example 3

> **Input**: `nums = [2,2,3,1]`  
> **Output**: `1`  
> **Explanation**:  
> The first distinct maximum is 3.  
> The second distinct maximum is 2 (both 2's are counted together since they have the same value).  
> The third distinct maximum is 1.

## Constraints

> - `1 <= nums.length <= 10^4`
> - `-2^31 <= nums[i] <= 2^31 - 1`

## Code

```csharp
public int ThirdMax(int[] nums)
{
    switch (nums.Length)
    {
        case 1:
            return nums[0];
        case 2:
            return nums[0] < nums[1] ? nums[1] : nums[0];
    }

    Array.Sort(nums, (a, b) => a.CompareTo(b));

    var superMax = nums[^1];
    var count = 1;
    for (var i = nums.Length - 2; i >= 0; i--)
    {
        if (nums[i+1] > nums[i])
        {
            count++;
            if(count > 2)
                return nums[i];
        }
    }

    return superMax;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O1()