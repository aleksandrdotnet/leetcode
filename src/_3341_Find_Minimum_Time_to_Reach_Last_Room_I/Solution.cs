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

        var m = moveTime.Length;
        var n = moveTime[0].Length;
        var dist = new int[m, n];

        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            dist[i, j] = int.MaxValue;

        dist[0, 0] = 0;

        var minHeap = new PriorityQueue<(int, (int, int)), int>();
        minHeap.Enqueue((0, src), 0); // (distance, position)

        while (minHeap.Count > 0)
        {
            var current = minHeap.Dequeue();
            var d = current.Item1;
            var u = current.Item2;

            if (u == dst)
                return d;

            var i = u.Item1;
            var j = u.Item2;

            if (d > dist[i, j])
                continue;

            foreach (var dir in dirs)
            {
                var x = i + dir[0];
                var y = j + dir[1];
                if (x < 0 || x >= m || y < 0 || y >= n)
                    continue;

                var newDist = Math.Max(moveTime[x][y], d) + 1;
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