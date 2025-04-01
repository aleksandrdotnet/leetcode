# 28. Find the Index of the First Occurrence in a String

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/string_matching-blue)

[28. Find the Index of the First Occurrence in a String](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/)

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle
is not part of haystack.

## Example 1

> **Input**: `haystack = "sadbutsad", needle = "sad"`  
> **Output**: `0`  
> **Explanation**: "sad" occurs at index 0 and 6.
> The first occurrence is at index 0, so we return 0.

## Example 2

> **Input**: `haystack = "leetcode", needle = "leeto"`  
> **Output**: `-1`  
> **Explanation**: "leeto" did not occur in "leetcode", so we return -1.

## Constraints

> - `1 <= haystack.length, needle.length <= 10^4`
> - `haystack and needle consist of only lowercase English characters.`

## Code

```csharp
public int StrStr(string haystack, string needle)
{
    for (var i = 0; i < haystack.Length; i++)
    {
        var flag = false;
        for (var j = 0; j < needle.Length; j++)
        {
            if (i + j >= haystack.Length || haystack[i + j] != needle[j])
            {
                flag = true;
                break;
            }
        }

        if (!flag)
            return i;
    }

    return -1;
}
```

## Complexity

> **Time complexity**: O(n*m)  
> **Space complexity**: O(1)