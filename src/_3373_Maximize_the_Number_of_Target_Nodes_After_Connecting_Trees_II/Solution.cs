namespace _3373_Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_II;

public class Solution
{
    // BFS для подсчёта количества узлов на чётных уровнях
    // Если `included` передан, отмечает, какие узлы на чётных уровнях
    private int BFS(int start, List<List<int>> adj, bool[] included)
    {
        var queue = new Queue<Pair>();
        queue.Enqueue(new Pair(start, -1));
        var count = 0;
        var level = 0;

        while (queue.Count > 0)
        {
            var size = queue.Count;
            if (level % 2 == 0)
                count += size;

            for (var i = 0; i < size; i++)
            {
                var currPair = queue.Dequeue();
                var curr = currPair.First;
                var parent = currPair.Second;

                if (included != null && level % 2 == 0) included[curr] = true;

                foreach (var v in adj[curr])
                {
                    if (v == parent) continue;
                    queue.Enqueue(new Pair(v, curr));
                }
            }

            level++;
        }

        return count;
    }

    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
        var n1 = edges1.Length + 1;
        var n2 = edges2.Length + 1;

        var adj1 = new List<List<int>>();
        var adj2 = new List<List<int>>();

        for (var i = 0; i < n1; i++) adj1.Add(new List<int>());
        for (var i = 0; i < n2; i++) adj2.Add(new List<int>());

        foreach (var edge in edges1)
        {
            adj1[edge[0]].Add(edge[1]);
            adj1[edge[1]].Add(edge[0]);
        }

        foreach (var edge in edges2)
        {
            adj2[edge[0]].Add(edge[1]);
            adj2[edge[1]].Add(edge[0]);
        }

        // Step 1: получить количество узлов на чётных уровнях в tree2
        var evenCount2 = BFS(0, adj2, null);
        var oddCount2 = n2 - evenCount2;
        var best2 = Math.Max(evenCount2, oddCount2);

        // Step 2: BFS на tree1, с пометкой узлов на чётных уровнях
        var included = new bool[n1];
        var evenCount1 = BFS(0, adj1, included);

        // Step 3: Ответ для каждого узла в tree1
        var ans = new int[n1];
        for (var i = 0; i < n1; i++)
            if (included[i])
                ans[i] = evenCount1 + best2;
            else
                ans[i] = n1 - evenCount1 + best2;

        return ans;
    }

    private class Pair
    {
        public readonly int First;
        public readonly int Second;

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}