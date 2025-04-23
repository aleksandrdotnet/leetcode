# 66. Plus One

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/math-blue)

[66. Plus One](https://leetcode.com/problems/valid-palindrome/description/)

```
You are given a large integer represented as an integer array digits,
where each digits[i] is the ith digit of the integer.
The digits are ordered from most significant to least significant in left-to-right order.
The large integer does not contain any leading 0's. 
Increment the large integer by one and return the resulting array of digits.  
```

## Example 1

```
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124. Thus, the result should be [1,2,4].
```

## Example 2

```
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321. Incrementing by one gives 4321 + 1 = 4322. Thus, the result should be [4,3,2,2].
```

## Constraints

```
1 <= digits.length <= 100
0 <= digits[i] <= 9 
digits does not contain any leading 0's.
```

## Code

```csharp
public int[] PlusOne(int[] digits)
{
    var item = digits[^1] + 1;
    var c = item / 10;
    digits[^1] = item % 10;
    
    for (var i = digits.Length - 2; i >= 0; i--)
    {
        item = digits[i] + c;

        c = item / 10;
        
        digits[i] = item % 10;
    }

    if (c == 1)
    {
        var arr = new int[digits.Length + 1];
        arr[0] = c;
        
        Array.Copy(digits, 0, arr, 1, digits.Length);

        return arr;
    }
    
    return digits;
}

// BUT 
public int[] PlusOne(int[] digits)
{
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }

    // If we reach here, all digits were 9, e.g., 999 -> 1000
    int[] result = new int[digits.Length + 1];
    result[0] = 1; // All other elements are 0 by default
    return result;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)