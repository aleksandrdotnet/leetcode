# 3341. Find Minimum Time to Reach Last Room I

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/graph-blue)
![Topics](https://img.shields.io/badge/heap_(prioriry_queue)-blue)
![Topics](https://img.shields.io/badge/matrix-blue)
![Topics](https://img.shields.io/badge/shortest_path-blue)

[3341. Find Minimum Time to Reach Last Room I](https://leetcode.com/problems/find-minimum-time-to-reach-last-room-i/description/?envType=daily-question&envId=2025-05-07)

```
There is a dungeon with n x m rooms arranged as a grid.

You are given a 2D array moveTime of size n x m, 
where moveTime[i][j] represents the minimum time in seconds when you can start moving to that room. 
You start from the room (0, 0) at time t = 0 
and can move to an adjacent room. Moving between adjacent rooms takes exactly one second.

Return the minimum time to reach the room (n - 1, m - 1).

Two rooms are adjacent if they share a common wall, either horizontally or vertically.
```

## Example 1

```
Input: moveTime = [[0,4],[4,4]]

Output: 6

Explanation:

The minimum time required is 6 seconds.

At time t == 4, move from room (0, 0) to room (1, 0) in one second.
At time t == 5, move from room (1, 0) to room (1, 1) in one second.
```

## Example 2

```
Input: moveTime = [[0,0,0],[0,0,0]]

Output: 3

Explanation:

The minimum time required is 3 seconds.

At time t == 0, move from room (0, 0) to room (1, 0) in one second.
At time t == 1, move from room (1, 0) to room (1, 1) in one second.
At time t == 2, move from room (1, 1) to room (1, 2) in one second.
```

# Example 3

```
Input: moveTime = [[0,1],[1,2]]

Output: 3
```

## Constraints

```
2 <= n == moveTime.length <= 50
2 <= m == moveTime[i].length <= 50
0 <= moveTime[i][j] <= 10^9
```

## Code

```csharp
namespace _3341_Find_Minimum_Time_to_Reach_Last_Room_I;

public class Solution
{
    public int MinTimeToReach(int[][] moveTime)
    {
        return Dijkstra(moveTime, (0, 0), (moveTime.Length - 1, moveTime[0].Length - 1));
    }

    private int Dijkstra(int[][] moveTime, (int, int) src, (int, int) dst)
    {
        int[][] dirs =
        [
            [0, 1],
            [1, 0],
            [0, -1],
            [-1, 0]
        ];

        int m = moveTime.Length;
        int n = moveTime[0].Length;
        int[,] dist = new int[m, n];

        for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            dist[i, j] = int.MaxValue;

        dist[0, 0] = 0;

        var minHeap = new PriorityQueue<(int, (int, int)), int>();
        minHeap.Enqueue((0, src), 0); // (distance, position)

        while (minHeap.Count > 0)
        {
            var current = minHeap.Dequeue();
            int d = current.Item1;
            var u = current.Item2;

            if (u.Equals(dst))
                return d;

            int i = u.Item1;
            int j = u.Item2;

            if (d > dist[i, j])
                continue;

            foreach (var dir in dirs)
            {
                int x = i + dir[0];
                int y = j + dir[1];
                if (x < 0 || x >= m || y < 0 || y >= n)
                    continue;

                int newDist = Math.Max(moveTime[x][y], d) + 1;
                if (newDist < dist[x, y])
                {
                    dist[x, y] = newDist;
                    minHeap.Enqueue((newDist, (x, y)), newDist);
                }
            }
        }

        return -1;
    }
}   
```

## Complexity

> **Time complexity**: O(m * n * log(m * n))  
> **Space complexity**: O(m * n)