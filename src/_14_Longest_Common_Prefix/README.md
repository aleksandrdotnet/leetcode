# 14. Longest Common Prefix

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/trie-blue)

[14. Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix/description/)

Write a function to find the longest common prefix string amongst an array of strings. If there is no common prefix,
return an empty string "".

## Example 1

> **Input**: `strs = ["flower","flow","flight"]`  
> **Output**: `"fl"`

## Example 2

> **Input**: `strs = ["dog","racecar","car"]`  
> **Output**: `""`  
> **Explanation**: There is no common prefix among the input strings.

## Constraints

> - `1 <= strs.length <= 200`
> - `0 <= strs[i].length <= 200`
> - `strs[i] consists of only lowercase English letters if it is non-empty.`

## Code

```csharp
public string LongestCommonPrefix(string[] strs)
{
    var result = new StringBuilder();

    var first = strs.First();
    for (var i = 0; i < first.Length; i++)
    {
        for (var j = 1; j < strs.Length; j++)
        {
            if (i >= strs[j].Length)
                return result.ToString();
            
            if(first[i] != strs[j][i])
                return result.ToString();
        }
        
        result.Append(first[i]);
    }
    
    return result.ToString();
}
```

## Complexity

> **Time complexity**: O(n*k)  
> **Space complexity**: O(n*k)