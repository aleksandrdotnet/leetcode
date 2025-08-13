# 392. Is Subsequence

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/dynamic_programming-blue)

[392. Is Subsequence](https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=leetcode-75)

```
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
```

## Example 1
```
Input: s = "abc", t = "ahbgdc"
Output: true
```

## Example 2
```
Input: s = "axc", t = "ahbgdc"
Output: false
```

## Constraints
```
0 <= s.length <= 100
0 <= t.length <= 10^4
s and t consist only of lowercase English letters.
```

Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?

## Code
```csharp
public bool IsSubsequence(string s, string t)
{
    if (s.Length == 0)
        return true;

    var left = 0;
    for (var i = 0; i < t.Length; i++)
    {
        if(left == s.Length) return true;

        if (t[i] == s[left])
            left++;
    }
    
    return left == s.Length; 
}
```

## Complexity
> **Time complexity**: O(n)  
> **Space complexity**: O(1)