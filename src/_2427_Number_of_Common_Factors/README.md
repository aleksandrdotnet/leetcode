# 2427. Number of Common Factors

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/enumeration-blue)
![Topics](https://img.shields.io/badge/number_theory-blue)

[2427. Number of Common Factors](https://leetcode.com/problems/number-of-common-factors/description/)

Given two positive integers `a` and `b`, return the number of common factors of `a` and `b`.

An integer `x` is a common factor of a and `b` if `x` divides both `a` and `b`.



## Example 1

> **Input**: `a = 12, b = 6`  
> **Output**: `4`  
> **Explanation**: `The common factors of 12 and 6 are 1, 2, 3, 6.`

## Example 2

> **Input**: `a = 25, b = 30`  
> **Output**: `2`  
> **Explanation**: `The common factors of 25 and 30 are 1, 5.`

## Constraints

> - `1 <= a, b <= 1000`

## Code

```csharp
public int CommonFactors(int a, int b)
{
    var result = 1 + (a == b && a > 1 ? 1 : 0);
    var m = Math.Min(Math.Min(a, b), Math.Max(a, b)/2);
    
    for (var i = 2; i <= m; i++)
    {
        if (a % i == 0 && b % i == 0)
            result++;
    }
    
    return result;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)

## Idea
> Try to think about GCD