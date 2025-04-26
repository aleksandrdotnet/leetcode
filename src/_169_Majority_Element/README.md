# 169. Majority Element

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/divide_and_conquer-blue)
![Topics](https://img.shields.io/badge/sorting-blue)
![Topics](https://img.shields.io/badge/counting-blue)

[169. Majority Element](src/_169_Majority_Element)

```
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. 
You may assume that the majority element always exists in the array.
```

## Example 1

```
Input: nums = [3,2,3]
Output: 3
```

## Example 2

```
Input: nums = [2,2,1,1,1,2,2]
Output: 2

```

## Constraints

```
n == nums.length
1 <= n <= 5 * 10^4
-10^9 <= nums[i] <= 10^9
```

## Code

```csharp
// Implement 1
public int MajorityElement(int[] nums)
{
    var limit = nums.Length / 2;
    var dict = new Dictionary<int, int>();
    
    foreach (var number in nums)
    {
        if (dict.TryGetValue(number, out var count))
        {
            if (count + 1 > limit)
                return number;

            dict[number] = count + 1;
        }
        else
            dict[number] = 1;
    }

    return dict[0];
}

// Implement 2
// Boyer-Moore Majority Vote Algorithm
public int MajorityElement(int[] nums)
{
    int candidate = 0, count = 0;

    foreach (var num in nums)
    {
        if (count == 0)
        {
            candidate = num;
        }

        count += num == candidate ? 1 : -1;
    }

    return candidate;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O()