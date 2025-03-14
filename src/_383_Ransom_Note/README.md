# 383. Ransom Note

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/counting-blue)

Given two strings `ransomNote` and `magazine`, return `true` if `ransomNote` can be constructed by using the letters
from `magazine` and false otherwise.

Each letter in `magazine` can only be used once in `ransomNote`.

## Example 1

> **Input**: `ransomNote = "a", magazine = "b"`  
> **Output**: `false`

## Example 2

> **Input**: `ransomNote = "aa", magazine = "ab"`  
> **Output**: `false`

## Example 3

> **Input**: `ransomNote = "aa", magazine = "aab"`  
> **Output**: `true`

## Constraints

> `1 <= ransomNote.length, magazine.length <= 105`  
> `ransomNote` and `magazine` consist of lowercase English letters.

## Code

```csharp
public static bool CanConstruct(string ransomNote, string magazine)
{
    var hs = new Dictionary<char, int>();
    foreach (var ch in magazine)
    {
        if (!hs.TryAdd(ch, 1))
            hs[ch]++;
    }

    foreach (var r in ransomNote)
    {
        if (!hs.TryGetValue(r, out var h) || h <= 0)
            return false;

        hs[r]--;
    }

    return true;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(logn)