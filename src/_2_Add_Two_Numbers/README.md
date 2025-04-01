# 2. Add Two Numbers

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/linked_list-blue)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/recursion-blue)

[2. Add Two Numbers](https://leetcode.com/problems/add-two-numbers/description/)

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order,
and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

## Example 1

> 2 → 4 → 3  
> 5 → 6 → 4  
> ─────  
> 7 → 0 → 8  
> **Input**: `l1 = [2,4,3], l2 = [5,6,4]`  
> **Output**: `[7,0,8]`  
> **Explanation**: `342 + 465 = 807`

## Example 2

> **Input**: `l1 = [0], l2 = [0]`
> **Output**: `[0]`

## Example 3

> **Input**: `l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]`
> **Output**: `[8,9,9,9,0,0,0,1]`

## Constraints

> -`The number of nodes in each linked list is in the range [1, 100]`
> - `0 <= Node.val <= 9`
> - `It is guaranteed that the list represents a number that does not have leading zeros.`

## Code

```csharp
public static bool IsPalindrome(int x)
{
    if (x < 0) return false;

    var res = x.ToString();
    for (int i = 0, j = res.Length - 1; i < res.Length/2; i++, j--)
        if(res[i] != res[j]) return false;
    return true;
}

public static bool IsPalindromeBest(int x)
{
    if (x < 0 || (x % 10 == 0 && x != 0)) return false;

    int reversed = 0;

    while (x > reversed)
    {
        reversed = reversed * 10 + x % 10;
        x /= 10;
    }

    return x == reversed || x == reversed / 10;
}
```

## Complexity

> **Time complexity**: O(logn)  
> **Space complexity**: O(1)