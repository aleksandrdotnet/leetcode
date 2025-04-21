# 367. Valid Perfect Square

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/binary_search-blue)

[367. Valid Perfect Square](https://leetcode.com/problems/valid-perfect-square/description/)

```
Given a positive integer num, return true if num is a perfect square or false otherwise.

A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.

You must not use any built-in library function, such as sqrt.
```

## Example 1

```
Input: num = 16
Output: true
Explanation: We return true because 4 * 4 = 16 and 4 is an integer.
```

## Example 2

```
Input: num = 14
Output: false
Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
```

## Constraints

```
1 <= num <= 2^31 - 1
```

## Code

```csharp
public bool IsPerfectSquare(int num)
{
    switch (num)
    {
        case < 0:
            return false;
        case 0:
        case 1:
            return true;
    }

    var left = 0;
    var right = num / 2;

    while (left <= right)
    {
        var mid = left + (right - left) / 2;
        var square = (long)mid * mid;
        if (square == num)
            return true;
        if (square < num)
            left = mid + 1;
        else
            right = mid - 1;
    }
    
    return false;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)