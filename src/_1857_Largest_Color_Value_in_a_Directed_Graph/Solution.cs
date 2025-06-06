namespace _1857_Largest_Color_Value_in_a_Directed_Graph;

public class Solution
{
    public int LargestPathValue(string colors, int[][] edges)
    {
        var n = colors.Length;

        // 1. Построение графа и массива входящих степеней
        var graph = new List<int>[n];
        var indegree = new int[n];
        for (var i = 0; i < n; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            int from = edge[0], to = edge[1];
            graph[from].Add(to);
            indegree[to]++;
        }

        // 2. Инициализация DP: dp[i][c] - макс. количество цвета c до вершины i
        var dp = new int[n][];
        for (var i = 0; i < n; i++)
            dp[i] = new int[26];

        var queue = new Queue<int>();

        // 3. Добавляем все вершины без входящих ребер (начальные точки)
        for (var i = 0; i < n; i++)
            if (indegree[i] == 0)
                queue.Enqueue(i);

        var visitedCount = 0;
        var maxColorValue = 0;

        // 4. Топологическая сортировка (Kahn’s algorithm)
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            visitedCount++;

            // Увеличиваем счетчик для текущего цвета
            var colorIndex = colors[node] - 'a';
            dp[node][colorIndex]++;
            maxColorValue = Math.Max(maxColorValue, dp[node][colorIndex]);

            // Обновляем соседей
            foreach (var neighbor in graph[node])
            {
                for (var c = 0; c < 26; c++) dp[neighbor][c] = Math.Max(dp[neighbor][c], dp[node][c]);

                indegree[neighbor]--;
                if (indegree[neighbor] == 0)
                    queue.Enqueue(neighbor);
            }
        }

        // Если остались непосещенные вершины — значит, в графе цикл
        return visitedCount == n ? maxColorValue : -1;
    }
}