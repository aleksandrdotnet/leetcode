# 1071. Greatest Common Divisor of Strings

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/string-blue)

[1071. Greatest Common Divisor of Strings](https://leetcode.com/problems/greatest-common-divisor-of-strings/description/?envType=study-plan-v2&envId=leetcode-75)

```
For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
```

## Example 1

```
Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
```

## Example 2

```
Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
```

## Constraints

```
1 <= str1.length, str2.length <= 1000
str1 and str2 consist of English uppercase letters.
```

## Code

```csharp
public string GcdOfStrings(string str1, string str2)
{
    if (str1 + str2 != str2 + str1) return "";

    var a = str1.Length;
    var b = str2.Length;

    // GCD
    while (b > 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return str1.Substring(0, a);
}
```

## Complexity

> **Time complexity**: O()  
> **Space complexity**: O()