# 151. Reverse Words in a String

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)

[151. Reverse Words in a String](https://leetcode.com/problems/reverse-words-in-a-string/description/?envType=study-plan-v2&envId=leetcode-75)

```
Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
```

## Example 1

```
ExaInput: s = "the sky is blue"
Output: "blue is sky the"
```

## Example 2

```
Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
```

## Constraints

```
1 <= s.length <= 10^4
s contains English letters (upper-case and lower-case), digits, and spaces ' '.
There is at least one word in s.
```

## Code

```csharp
public string ReverseWords(string s)
{
    var result = new StringBuilder();

    for (var i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] == ' ')
            continue;

        var j = i;
        while (j > 0 && s[j - 1] != ' ')
        {
            j--;
        }

        result.Append(s[j..(i + 1)]);

        var lastSpace = false;
        var k = j - 1;
        while (k >= 0)
        {
            if (s[k] != ' ')
            {
                lastSpace = true;
                break;
            }

            k--;
        }

        if (lastSpace)
            result.Append(' ');

        i = j;
    }

    return result.ToString();
}
```

Follow-up: If the string data type is mutable in your language, can you solve it in-place with O(1) extra space?

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)