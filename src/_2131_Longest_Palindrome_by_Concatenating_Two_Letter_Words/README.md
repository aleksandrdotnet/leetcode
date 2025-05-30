# 2131. Longest Palindrome by Concatenating Two Letter Words

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/greedy-blue)
![Topics](https://img.shields.io/badge/counting-blue)

[2131. Longest Palindrome by Concatenating Two_Letter Words](https://leetcode.com/problems/longest-palindrome-by-concatenating-two-letter-words/description/?envType=daily-question&envId=2025-05-25)

```
You are given an array of strings words. 
Each element of words consists of two lowercase English letters.
Create the longest possible palindrome by selecting 
some elements from words and concatenating them in any order. 
Each element can be selected at most once.

Return the length of the longest palindrome that you can create. 
If it is impossible to create any palindrome, return 0.

A palindrome is a string that reads the same forward and backward.
```

## Example 1

```
Input: words = ["lc","cl","gg"]
Output: 6
Explanation: One longest palindrome is "lc" + "gg" + "cl" = "lcggcl", of length 6.
Note that "clgglc" is another longest palindrome that can be created.
```

## Example 2

```
Input: words = ["ab","ty","yt","lc","cl","ab"]
Output: 8
Explanation: One longest palindrome is "ty" + "lc" + "cl" + "yt" = "tylcclyt", of length 8.
Note that "lcyttycl" is another longest palindrome that can be created.
```

## Example 3

```
Input: words = ["cc","ll","xx"]
Output: 2
Explanation: One longest palindrome is "cc", of length 2.
Note that "ll" is another longest palindrome that can be created, and so is "xx".
```

## Constraints

```
1 <= words.length <= 10^5
words[i].length == 2
words[i] consists of lowercase English letters.
```

## Code

```csharp
public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var result = 0;
        var freq = new int[26, 26];

        foreach (var word in words)
        {
            var cl = word[0] - 'a';
            var cr = word[1] - 'a';

            if (freq[cr, cl] != 0)
            {
                freq[cr, cl]--;
                result += 4;
            }
            else
            {
                freq[cl, cr]++;
            }
        }

        if (result % 2 == 0)
        {
            for (var i = 0; i < 26; i++)
            {
                if (freq[i, i] != 0)
                    return result + 2;
            }
        }

        return result;
    }
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)