# 790. Domino and Tromino Tiling

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/dynamic_programming-blue)

[790. Domino and Tromino Tiling](https://leetcode.com/problems/domino-and-tromino-tiling/description/?envType=daily-question&envId=2025-05-05)

```
You have two types of tiles: a 2 x 1 domino shape and a tromino shape. 
You may rotate these shapes.
```

![png](Resources/790-1.jpg)

```
Given an integer n, return the number of ways to tile an 2 x n board. Since the answer may be very large, return it modulo 109 + 7.

In a tiling, every square must be covered by a tile. 
Two tilings are different if and only if there are two 4-directionally adjacent cells on the board such that exactly one of the tilings has both squares occupied by a tile.
```

## Example 1

![png](Resources/790-2.jpg)

```
Input: n = 3
Output: 5
Explanation: The five different ways are show above.
```

## Example 2

```
Input: n = 1
Output: 1
```

## Constraints

```
1 <= n <= 1000
```

## Code

```csharp
public int NumTilings(int n)
{
    var result = new int[n < 4 ? 4 : n + 1];
    result[0] = 0;
    result[1] = 1;
    result[2] = 2;
    result[3] = 5;

    if (n < 4)
        return result[n];

    const int mod = 1_000_000_007;
    for (var i = 4; i <= n; i++)
        result[i] = (2 * result[i - 1] % mod + result[i - 3] % mod) % mod;

    return result[n];
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)