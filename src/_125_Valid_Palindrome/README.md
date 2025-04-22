# 125. Valid Palindrome

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)

[125. Valid Palindrome](https://leetcode.com/problems/valid-palindrome/description/)

```
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.```

## Example 1
```

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

```

## Example 2
```

Input: s = "race a car" Output: false Explanation: "raceacar" is not a palindrome.

```

## Constraints
```

1 <= s.length <= 2 * 10^5
s consists only of printable ASCII characters.

```

## Code
```csharp
public bool IsPalindrome(string s)
{
    var left = 0;
    var right = s.Length - 1;
    while (left <= right)
    {
        if (!IsAlphaNumeric(s[left]))
        {
            left++;
            continue;
        }

        if (!IsAlphaNumeric(s[right]))
        {
            right--;
            continue;
        }
        
        if(char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
            return false;
        
        left++; right--;
    }

    return true;

    bool IsAlphaNumeric(char c)
    {
        return c is >= '0' and <= '9' or >= 'A' and <= 'Z' or >= 'a' and <= 'z';
    }
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)