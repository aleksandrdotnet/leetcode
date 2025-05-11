# 3342. Find Minimum Time to Reach Last Room II

![Complexity](https://img.shields.io/badge/easy-green)
![Topics](https://img.shields.io/badge/AAA-blue)
![Topics](https://img.shields.io/badge/BBB-blue)

[3342. Find Minimum Time to Reach Last Room II](src/_3342_Find_Minimum_Time_to_Reach_Last_Room_II)

```
There is a dungeon with n x m rooms arranged as a grid.

You are given a 2D array moveTime of size n x m, where moveTime[i][j] represents the minimum time in seconds when you can start moving to that room. You start from the room (0, 0) at time t = 0 and can move to an adjacent room. Moving between adjacent rooms takes one second for one move and two seconds for the next, alternating between the two.

Return the minimum time to reach the room (n - 1, m - 1).

Two rooms are adjacent if they share a common wall, either horizontally or vertically.
```

## Example 1

```
Input: moveTime = [[0,4],[4,4]]

Output: 7

Explanation:

The minimum time required is 7 seconds.

At time t == 4, move from room (0, 0) to room (1, 0) in one second.
At time t == 5, move from room (1, 0) to room (1, 1) in two seconds.
```

## Example 2

```
Input: moveTime = [[0,0,0,0],[0,0,0,0]]

Output: 6

Explanation:

The minimum time required is 6 seconds.

At time t == 0, move from room (0, 0) to room (1, 0) in one second.
At time t == 1, move from room (1, 0) to room (1, 1) in two seconds.
At time t == 3, move from room (1, 1) to room (1, 2) in one second.
At time t == 4, move from room (1, 2) to room (1, 3) in two seconds.
```

## Example 3

```
Input: moveTime = [[0,1],[1,2]]

Output: 4
```

## Constraints

```
2 <= n == moveTime.length <= 750
2 <= m == moveTime[i].length <= 750
0 <= moveTime[i][j] <= 10^9
```

## Code

```csharp
public int MinTimeToReach(int[][] moveTime)
{
    var result = AStar(moveTime, (0, 0), (moveTime.Length - 1, moveTime[0].Length - 1));

    return result;
}

private static int AStar(int[][] grid, (int x, int y) start, (int x, int y) goal)
{
    var openSet = new PriorityQueue<(int x, int y), double>();
    openSet.Enqueue(start, 0);

    var cameFrom = new Dictionary<(int, int), (int, int)>();
    var gScore = new Dictionary<(int, int), int> { [start] = 0 };

    var rows = grid.Length;
    var cols = grid[0].Length;

    while (openSet.Count > 0)
    {
        var current = openSet.Dequeue();

        if (current == goal)
            //return ReconstructPath(cameFrom, current);
            return gScore[goal];
        
        foreach (var neighbor in GetNeighbors(current, grid, rows, cols, gScore[current]))
        {
            var tentativeG = neighbor.Item2 + ((neighbor.Item1.Item1+ neighbor.Item1.Item2) % 2 == 1 ? 1 : 2);

            if (!gScore.TryGetValue(neighbor.Item1, out var g) || tentativeG < g)
            {
                gScore[neighbor.Item1] = tentativeG;
                var fScore = tentativeG + Heuristic(neighbor.Item1, goal);
                cameFrom[neighbor.Item1] = current;
                openSet.Enqueue(neighbor.Item1, fScore);
            }
        }
    }

    return -1; // путь не найден
}

private static double Heuristic((int x, int y) a, (int x, int y) b)
{
    // Манхэттенская эвристика
    return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
}

private static bool Flag = true;
private static IEnumerable<((int, int), int)> GetNeighbors((int x, int y) node, int[][] grid, int rows, int cols,
    int weight)
{
    int[] dx = { 0, 1, 0, -1 };
    int[] dy = { -1, 0, 1, 0 };

    for (int i = 0; i < 4; i++)
    {
        int nx = node.x + dx[i];
        int ny = node.y + dy[i];

        if (nx >= 0 && ny >= 0 && nx < rows && ny < cols)
        {
            var newWeight = grid[nx][ny] > weight ? grid[nx][ny] : weight;
            
            yield return ((nx, ny), newWeight);
        }
    }
}

private static List<(int, int)> ReconstructPath(Dictionary<(int, int), (int, int)> cameFrom, (int, int) current)
{
    var path = new List<(int, int)> { current };
    while (cameFrom.ContainsKey(current))
    {
        current = cameFrom[current];
        path.Add(current);
    }

    path.Reverse();
    return path;
}
```

## Complexity

> **Time complexity**: O(m * n * log(m * n))  
> **Space complexity**: O(m * n)