# 1550. Three Consecutive Odds

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)

[1550. Three Consecutive Odds](https://leetcode.com/problems/three-consecutive-odds/description/?envType=daily-question&envId=2025-05-11)

```
Given an integer array arr, 
return true if there are three consecutive odd numbers in the array. 
Otherwise, return false.
```

## Example 1

```
Input: arr = [2,6,4,1]
Output: false
Explanation: There are no three consecutive odds.
```

## Example 2

```
Input: arr = [1,2,34,3,4,5,7,23,12]
Output: true
Explanation: [5,7,23] are three consecutive odds.
```

## Constraints

```
1 <= arr.length <= 1000
1 <= arr[i] <= 1000
```

## Code

```csharp
public bool ThreeConsecutiveOdds(int[] arr)
{
    for (var i = 2; i < arr.Length; i++)
    {
        var first = arr[i-2];
        var second = arr[i-1];
        var third = arr[i];

        if (first % 2 == 1 && second % 2 == 1 && third % 2 == 1)
            return true;
    }
    
    return false;
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(1)