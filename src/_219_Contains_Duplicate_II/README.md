# 219. Contains Duplicate II

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/sliding_window-blue)

[219. Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/description/)

```
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
```

## Example 1

```
Input: nums = [1,2,3,1], k = 3
Output: true
```

## Example 2

```
Input: nums = [1,0,1,1], k = 1
Output: true
```

## Example 2

```
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
```

## Constraints

```
1 <= nums.length <= 10^5
-109 <= nums[i] <= 10^9
0 <= k <= 10^5
```

## Code

```csharp
public bool ContainsNearbyDuplicate(int[] nums, int k)
{
    var dict = new Dictionary<int, int>();
    
    for (var right = 0; right < nums.Length; right++)
    {
        if (dict.TryGetValue(nums[right], out int left))
            if (right - left <= k)
                return true;
            
        dict[nums[right]] = right;
    }

    return false;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)