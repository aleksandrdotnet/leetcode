# 434. Number of Segments in a String

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/string-blue)

[434. Number of Segments in a String](https://leetcode.com/problems/number-of-segments-in-a-string/)

Given a string s, return the number of segments in the string. A segment is defined to be a contiguous sequence of
non-space characters.

## Example 1

> **Input**: `s = "Hello, my name is John"`  
> **Output**: `5`  
> **Explanation**: The five segments are ["Hello,", "my", "name", "is", "John"]

## Example 2

> **Input**: `s = "Hello"`  
> **Output**: `1`

## Constraints

> - `0 <= s.length <= 300`
> -
`s consists of lowercase and uppercase English letters, digits, or one of the following characters "!@#$%^&*()_+-=',.:"`

## Code

```csharp
public int CountSegments(string s)
{
    var str = s.Trim();
    var result = 0;

    if (string.IsNullOrEmpty(str))
        return result;

    foreach (var n in str.Split(' '))
    {
        if (n.Length != 0)
            result++;
    }

    return result;
}

public int CountSegments2(string s)
{
    if (string.IsNullOrWhiteSpace(s))
        return 0;

    var ans = s.Split([' '], StringSplitOptions.RemoveEmptyEntries);
    return ans.Length;
}

public int CountSegments3(string s)
{
    return Regex.Matches(s, @"[^ ]+").Count;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)