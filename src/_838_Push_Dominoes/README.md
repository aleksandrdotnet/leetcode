# 838. Push Dominoes

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/two_pointers-blue)
![Topics](https://img.shields.io/badge/string-blue)
![Topics](https://img.shields.io/badge/dynamic_programming-blue)

[838. Push Dominoes](https://leetcode.com/problems/push-dominoes/description/?envType=daily-question&envId=2025-05-02)

```
There are n dominoes in a line, and we place each domino vertically upright. In the beginning, we simultaneously push some of the dominoes either to the left or to the right.

After each second, each domino that is falling to the left pushes the adjacent domino on the left. Similarly, the dominoes falling to the right push their adjacent dominoes standing on the right.

When a vertical domino has dominoes falling on it from both sides, it stays still due to the balance of the forces.

For the purposes of this question, we will consider that a falling domino expends no additional force to a falling or already fallen domino.

You are given a string dominoes representing the initial state where:

dominoes[i] = 'L', if the ith domino has been pushed to the left,
dominoes[i] = 'R', if the ith domino has been pushed to the right, and
dominoes[i] = '.', if the ith domino has not been pushed.
Return a string representing the final state.
```

## Example 1

```
Input: dominoes = "RR.L"
Output: "RR.L"
Explanation: The first domino expends no additional force on the second domino.
```

## Example 2

![png](Resources/838.png)

```
Input: dominoes = ".L.R...LR..L.."
Output: "LL.RR.LLRRLL.."
```

## Constraints

```
n == dominoes.length
1 <= n <= 10^5
dominoes[i] is either 'L', 'R', or '.'.
```

## Code

```csharp
public string PushDominoes(string dominoes)
{
    var s = dominoes.ToCharArray();
    int L = -1, R = -1;

    for (var i = 0; i <= s.Length; i++)
    {
        if (i == s.Length || s[i] == 'R')
        {
            if (L < R)
            {
                while (R < i)
                {
                    s[R++] = 'R';
                }
            }

            R = i;
        }
        else if (s[i] == 'L')
        {
            if (R < L || (L == -1 && R == -1))
            {
                if (L == -1 && R == -1) L = 0;
                while (L < i)
                {
                    s[L++] = 'L';
                }
            }
            else
            {
                int l = R + 1;
                int r = i - 1;
                while (l < r)
                {
                    s[l++] = 'R';
                    s[r--] = 'L';
                }
            }

            L = i;
        }
    }

    return new string(s);
}
```

## Complexity

> **Time complexity**: O(n)  
> **Space complexity**: O(n)