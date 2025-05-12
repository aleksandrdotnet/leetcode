# 2094. Finding 3-Digit Even Numbers

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/sorting-blue)
![Topics](https://img.shields.io/badge/enumeration-blue)

[2094. Finding 3-Digit Even Numbers](https://leetcode.com/problems/finding-3-digit-even-numbers/description/?envType=daily-question&envId=2025-05-12)

```
You are given an integer array digits, where each element is a digit. The array may contain duplicates.

You need to find all the unique integers that follow the given requirements:

The integer consists of the concatenation of three elements from digits in any arbitrary order.
The integer does not have leading zeros.
The integer is even.
For example, if the given digits were [1, 2, 3], integers 132 and 312 follow the requirements.

Return a sorted array of the unique integers.
```

## Example 1
```
Input: digits = [2,1,3,0]
Output: [102,120,130,132,210,230,302,310,312,320]
Explanation: All the possible integers that follow the requirements are in the output array. 
Notice that there are no odd integers or integers with leading zeros.
```

## Example 2
```
Input: digits = [2,2,8,8,2]
Output: [222,228,282,288,822,828,882]
Explanation: The same digit can be used as many times as it appears in digits. 
In this example, the digit 8 is used twice each time in 288, 828, and 882. 
```

## Example 2
```
Input: digits = [3,7,5]
Output: []
Explanation: No even integers can be formed using the given digits.
```

## Constraints
```
3 <= digits.length <= 100
0 <= digits[i] <= 9
```

## Code
```csharp
public int[] FindEvenNumbers(int[] digits)
{
    var result = new List<int>();
    var dict = new int[10];
    foreach (var num in digits)
        dict[num]++;

    var n = new int[10];
    for (var num = 100; num < 1000; num += 2)
    {
        var ones = num % 10;
        var tens = (num / 10) % 10;
        var hund = num / 100;
        
        n[ones]++;
        n[tens]++;
        n[hund]++;

        if(n[ones] <= dict[ones] && n[tens] <= dict[tens] && n[hund] <= dict[hund])
        {
            result.Add(num);
        }

        n[ones] = 0;
        n[tens] = 0;
        n[hund] = 0;
    }

    return result.ToArray();
}
```

## Complexity
> **Time complexity**: O(n)  
> **Space complexity**: O(n)