# 1837. Sum of Digits in Base K

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)

[1837. Sum of Digits in Base K](https://leetcode.com/problems/sum-of-digits-in-base-k/description/)

Given an integer n (in base 10) and a base k, return the sum of the digits of n after converting n from base 10 to base
k. After converting, each digit should be interpreted as a base 10 number, and the sum should be returned in base 10.

## Example 1

> **Input**: `n = 34, k = 6`  
> **Output**: `9`  
> **Explanation**: 34 (base 10) expressed in base 6 is 54. 5 + 4 = 9.

## Example 2

> **Input**: `n = 10, k = 10`  
> **Output**: `1`  
> **Explanation**: n is already in base 10. 1 + 0 = 1.

## Constraints

> - `1 <= n <= 100`
> - `2 <= k <= 10`

## Code

```csharp
public int SumBase(int n, int k)
{
    int next = n / k;
    int result = n % k;

    while (next >= k)
    {
        result += next % k;
        next = next / k;
    }

    return result + next;
}
```

## Complexity

> **Time complexity**: O(logₖ(n))
> **Space complexity**: O(1)