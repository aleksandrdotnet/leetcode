# 20. Valid Parentheses

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/stack-blue)

[20. Valid Parentheses](https://leetcode.com/problems/valid-parentheses/)

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

## Example 1

> **Input**: s = "()"  
> **Output**: true

## Example 2

> **Input**: s = "()[]{}"  
> **Output**: true

## Example 3

> **Input**: s = "(]"  
> **Output**: false

## Example 4

> **Input**: s = "([])"  
> **Output**: true

## Constraints

> - `1 <= s.length <= 10^4`
> - `s consists of parentheses only '()[]{}'`

## Code

```csharp
private static readonly Dictionary<char, char> Brackets = new()
{
    { ')', '(' },
    { '}', '{' },
    { ']', '[' }
};

public bool IsValid(string s)
{
    var stack = new Stack<char>();
    foreach (var symbol in s)
    {
        if (Brackets.TryGetValue(symbol, out var open))
        {
            if (!stack.TryPop(out var closed) || closed != open)
                return false;
        }
        else
        {
            stack.Push(symbol);
        }
    }

    return stack.Count == 0;
}
```

## Complexity

> **Time complexity**: O()  
> **Space complexity**: O()