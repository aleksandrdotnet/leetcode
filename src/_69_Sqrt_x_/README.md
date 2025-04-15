# 69. Sqrt(x)

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/binary_search-blue)

[69. Sqrt(x)](https://leetcode.com/problems/sqrtx/description/)

Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer
should be non-negative as well. You must not use any built-in exponent function or operator. For example, do not use
pow(x, 0.5) in c++ or x ** 0.5 in python.

## Example 1

```
Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.
```

## Example 2

```
Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
```

## Constraints

> - `0 <= x <= 2^31 - 1`

## Code

```csharp
public int MySqrt(int x)
{
    if (x < 2) return x;

    int left = 1, right = x / 2, result = 0;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        long square = (long)mid * mid; // чтобы не было переполнения

        if (square == x)
            return mid;
        else if (square < x)
        {
            result = mid; // сохраняем последний успешный
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return result;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)