# 412. Fizz Buzz

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/math-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/simulation-blue)
![Topics](https://img.shields.io/badge/done-purple)

Given an integer `n`, return a string array `answer` (1-indexed) where:

`answer[i] == "FizzBuzz"` if `i` is divisible by `3` and `5`.
`answer[i] == "Fizz"` if `i` is divisible by `3`.
`answer[i] == "Buzz"` if `i` is divisible by `5`.
`answer[i] == i` (as a string) if none of the above conditions are true.

## Example 1
> **Input**: `n = 3`
> **Output**: `["1","2","Fizz"]`

## Example 2
> **Input**: `n = 5`
> **Output**: `["1","2","Fizz","4","Buzz"]`

## Example 3
> **Input**: `n = 15`
> **Output**: `["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]`

## Constraints
> `1 <= n <= 104`

## Code
```csharp
public static int[] Run(int[] input)
{
    var result = new int[input.Length];

    result[0] = input[0];
    for (var i = 1; i < input.Length; i++)
        result[i] = result[i - 1] + input[i];

    return result;
}
```