# 9. Palindrome Number

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)

[9. Palindrome Number](https://leetcode.com/problems/palindrome-number)

Given an integer `x`, return true if `x` is a `palindrome`, and false otherwise.

## Example 1

> **Input**: `x = 121`  
> **Output**: `true`  
> **Explanation**: `121 reads as 121 from left to right and from right to left.`

## Example 2

> **Input**: `x = -121`  
> **Output**: `false`  
> **Explanation**: `From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.`

## Example 3

> **Input**: `x = 10`
> **Output**: `false`
> **Explanation**: `Reads 01 from right to left. Therefore it is not a palindrome.`

## Constraints

> -`2^31 <= x <= 2^31 - 1`

## Code

```csharp
public static bool IsPalindrome(int x)
{
    if (x < 0) return false;

    var res = x.ToString();
    for (int i = 0, j = res.Length - 1; i < res.Length/2; i++, j--)
        if(res[i] != res[j]) return false;
    return true;
}

public static bool IsPalindromeBest(int x)
{
    if (x < 0 || (x % 10 == 0 && x != 0)) return false;

    int reversed = 0;

    while (x > reversed)
    {
        reversed = reversed * 10 + x % 10;
        x /= 10;
    }

    return x == reversed || x == reversed / 10;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)