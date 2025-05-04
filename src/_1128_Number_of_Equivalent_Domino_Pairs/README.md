# 1128. Number of Equivalent Domino Pairs

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/counting-blue)

[1128. Number of Equivalent Domino Pairs](https://leetcode.com/problems/number-of-equivalent-domino-pairs/description/?envType=daily-question&envId=2025-05-04)

```
Given a list of dominoes, dominoes[i] = [a, b] is equivalent to dominoes[j] = [c, d] if and only if either (a == c and b == d), or (a == d and b == c) - that is, one domino can be rotated to be equal to another domino.

Return the number of pairs (i, j) for which 0 <= i < j < dominoes.length, and dominoes[i] is equivalent to dominoes[j].
```

## Example 1

```
Input: dominoes = [[1,2],[2,1],[3,4],[5,6]]
Output: 1
```

## Example 2

```
Input: dominoes = [[1,2],[1,2],[1,1],[1,2],[2,2]]
Output: 3
```

## Constraints

```
1 <= dominoes.length <= 4 * 10^4
dominoes[i].length == 2
1 <= dominoes[i][j] <= 9
```

## Code

```csharp
public int NumEquivDominoPairs(int[][] dominoes)
{
    var dict = new Dictionary<int, int>();

    foreach (var domino in dominoes)
    {
        var key = domino[0] > domino[1] ? domino[0] * 10 + domino[1] : domino[1] * 10 + domino[0];
        dict[key] = dict.GetValueOrDefault(key, 0) + 1;
    }

    return dict
        .Where(x => x.Value > 1)
        .Sum(x => x.Value * (x.Value - 1) / 2);
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)