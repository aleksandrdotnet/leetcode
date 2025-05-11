namespace _3342_Find_Minimum_Time_to_Reach_Last_Room_II;

public class Solution
{
    private static bool Flag = true;

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
                var tentativeG = neighbor.Item2 + ((neighbor.Item1.Item1 + neighbor.Item1.Item2) % 2 == 1 ? 1 : 2);

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

    private static IEnumerable<((int, int), int)> GetNeighbors((int x, int y) node, int[][] grid, int rows, int cols,
        int weight)
    {
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { -1, 0, 1, 0 };

        for (var i = 0; i < 4; i++)
        {
            var nx = node.x + dx[i];
            var ny = node.y + dy[i];

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
}