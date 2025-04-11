# 1913. Maximum Product Difference Between Two Pairs

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/sorting-blue)

[1913. Maximum Product Difference Between Two Pairs](https://leetcode.com/problems/maximum-product-difference-between-two-pairs/description/)

The product difference between two pairs (a, b) and (c, d) is defined as (a * b) - (c * d). For example, the product
difference between (5, 6) and (2, 7) is (5 * 6) - (2 * 7) = 16. Given an integer array nums, choose four distinct
indices w, x, y, and z such that the product difference between pairs (nums[w], nums[x]) and (nums[y], nums[z]) is
maximized. Return the maximum such product difference.

## Example 1

> **Input**: `nums = [5,6,2,7,4]`  
> **Output**: `34`  
> **Explanation**: We can choose indices 1 and 3 for the first pair (6, 7) and indices 2 and 4 for the second pair (2,
> 4).
> The product difference is (6 * 7) - (2 * 4) = 34.

## Example 2

> **Input**: `nums = [4,2,5,9,7,4,8]`  
> **Output**: `64`  
> **Explanation**: We can choose indices 3 and 6 for the first pair (9, 8) and indices 1 and 5 for the second pair (2,
> 4).
> The product difference is (9 * 8) - (2 * 4) = 64.

## Constraints

> - `4 <= nums.length <= 10^4`
> - `1 <= nums[i] <= 10^4`

## Code

```csharp
public int MaxProductDifference(int[] nums)
{
    var max = new[] { 0, 0 };
    var min = new[] { 10001, 10001 };

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < min[0] || nums[i] < min[1])
        {
            if(nums[i] < min[0])
            {
                min[1] = min[0];
                min[0] = nums[i];
            }
            else
            {
                min[1] = nums[i];
            }
        }

        if (nums[i] > max[0] || nums[i] > max[1])
        {
            if(nums[i] > max[0])
            {
                max[1] = max[0];
                max[0] = nums[i];
            }
            else
            {
                max[1] = nums[i];
            }
        }
    }

    return max[0] * max[1] - min[0] * min[1];
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)