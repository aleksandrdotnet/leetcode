# 345. Reverse Vowels of a String

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)

[345. Reverse Vowels of a String](https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&envId=leetcode-75)

```
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
```

## Example 1

```
Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".
```

## Example 2

```
Input: s = "leetcode"

Output: "leotcede"
```

## Constraints

```
1 <= s.length <= 3 * 10^5
s consist of printable ASCII characters.
```

## Code

```csharp
public string ReverseVowels(string s)
{
    var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    var i = 0;
    var j = s.Length - 1;
    var result = new StringBuilder(s);
    
    while (i < j)
    {
        if (!vowels.Contains(s[i]))
        {
            i++;
        }
        else if (!vowels.Contains(s[j]))
        {
            j--;
        }
        else
        {
            result.Replace(s[i], s[j], i, 1);
            result.Replace(s[j], s[i], j, 1);
            i++;
            j--;
        }
    }
    
    return result.ToString();
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)