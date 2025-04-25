# 67. Add Binary

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/bit_manipulation-blue)
![Topics](https://img.shields.io/badge/simulation-blue)

[67. Add Binary](https://leetcode.com/problems/add-binary/description/)

```
Given two binary strings a and b, return their sum as a binary string.
```

## Example 1

```
Input: a = "11", b = "1"
Output: "100"
```

## Example 2

```
Input: a = "1010", b = "1011"
Output: "10101"
```

## Constraints

```
1 <= a.length, b.length <= 104
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
```

## Code

```csharp
public string AddBinary(string a, string b)
{
    var i = a.Length - 1;
    var j = b.Length - 1;
    var sb = new StringBuilder();
    var c = 0;

    while (i >= 0 || j >= 0 || c > 0)
    {
        var sum = c;
        if (i >= 0)
        {
            sum += a[i] == '1' ? 1 : 0;
            i--;
        }

        if (j >= 0)
        {
            sum += b[j] == '1' ? 1 : 0;
            j--;
        }

        c = sum / 2;
        sb.Insert(0, sum % 2);
    }

    return sb.ToString();
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)