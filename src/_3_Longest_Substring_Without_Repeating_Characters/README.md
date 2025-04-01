# 3. Longest Substring Without Repeating Characters

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/sliding_window-blue)

[3. Longest Substring Without Repeating Characters](https://leetcode.com/problems/sort-colors/description/)

Given a string `s`, find the length of the longest substring without duplicate characters.

## Example 1

> **Input**: `s = "abcabcbb"`  
> **Output**: `3`  
> **Explanation**: The answer is "abc", with the length of 3.

## Example 2

> **Input**: `s = "bbbbb"`  
> **Output**: `1`  
> **Explanation**: The answer is "b", with the length of 1.

## Example 2

> **Input**: `s = "pwwkew"`  
> **Output**: `3`  
> **Explanation**: The answer is "wke", with the length of 3.
> Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

## Constraints

> - `0 <= s.length <= 5 * 10^4`
> - `s consists of English letters, digits, symbols and spaces.`

## Code

```csharp
public int LengthOfLongestSubstring(string s)
{
    if(s.Length <= 1)
        return s.Length;
    
    var left = 0;
    var max = 0;
    
    var dict = new Dictionary<char, int>();
    for (var right = 0; right < s.Length; right++)
    {
        if (dict.TryGetValue(s[right], out var index))
        {
            left = Math.Max(left, index + 1);
        }
        
        dict[s[right]] = right;
        
        max = Math.Max(max, right - left + 1);
    }
    
    return max;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)