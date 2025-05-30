# 3373. Maximize the Number of Target Nodes After Connecting Trees II

![Complexity](https://img.shields.io/badge/hard-red)
![Topics](https://img.shields.io/badge/tree-blue)
![Topics](https://img.shields.io/badge/Depth_First_Search-blue)
![Topics](https://img.shields.io/badge/Breadth_First_Search-blue)

[3373. Maximize the Number of Target Nodes After Connecting Trees II](trees-ii/description/?envType=daily-question&envId=2025-05-29)

```
There exist two undirected trees with n and m nodes, labeled from [0, n - 1] and [0, m - 1], respectively.

You are given two 2D integer arrays edges1 and edges2 of lengths n - 1 and m - 1, respectively, where edges1[i] = [ai, bi] indicates that there is an edge between nodes ai and bi in the first tree and edges2[i] = [ui, vi] indicates that there is an edge between nodes ui and vi in the second tree.

Node u is target to node v if the number of edges on the path from u to v is even. Note that a node is always target to itself.

Return an array of n integers answer, where answer[i] is the maximum possible number of nodes that are target to node i of the first tree if you had to connect one node from the first tree to another node in the second tree.

Note that queries are independent from each other. That is, for every query you will remove the added edge before proceeding to the next query.
```

## Example 1

![png](Resources/3373-1.png)

```
Input: edges1 = [[0,1],[0,2],[2,3],[2,4]], edges2 = [[0,1],[0,2],[0,3],[2,7],[1,4],[4,5],[4,6]]

Output: [8,7,7,8,8]

Explanation:

For i = 0, connect node 0 from the first tree to node 0 from the second tree.
For i = 1, connect node 1 from the first tree to node 4 from the second tree.
For i = 2, connect node 2 from the first tree to node 7 from the second tree.
For i = 3, connect node 3 from the first tree to node 0 from the second tree.
For i = 4, connect node 4 from the first tree to node 4 from the second tree.
```

## Example 2

![png](Resources/3373-2.png)

```
Input: edges1 = [[0,1],[0,2],[0,3],[0,4]], edges2 = [[0,1],[1,2],[2,3]]

Output: [3,6,6,6,6]

Explanation:

For every i, connect node i of the first tree with any node of the second tree.
```

## Constraints

```
2 <= n, m <= 105
edges1.length == n - 1
edges2.length == m - 1
edges1[i].length == edges2[i].length == 2
edges1[i] = [ai, bi]
0 <= ai, bi < n
edges2[i] = [ui, vi]
0 <= ui, vi < m
The input is generated such that edges1 and edges2 represent valid trees.
```

## Code

```csharp
public class Solution
{
    private class Pair
    {
        public int First;
        public int Second;
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }

    // BFS для подсчёта количества узлов на чётных уровнях
    // Если `included` передан, отмечает, какие узлы на чётных уровнях
    private int BFS(int start, List<List<int>> adj, bool[] included)
    {
        var queue = new Queue<Pair>();
        queue.Enqueue(new Pair(start, -1));
        int count = 0;
        int level = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            if (level % 2 == 0)
                count += size;

            for (int i = 0; i < size; i++)
            {
                var currPair = queue.Dequeue();
                int curr = currPair.First;
                int parent = currPair.Second;

                if (included != null && level % 2 == 0)
                {
                    included[curr] = true;
                }

                foreach (int v in adj[curr])
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
        int n1 = edges1.Length + 1;
        int n2 = edges2.Length + 1;

        var adj1 = new List<List<int>>();
        var adj2 = new List<List<int>>();

        for (int i = 0; i < n1; i++) adj1.Add(new List<int>());
        for (int i = 0; i < n2; i++) adj2.Add(new List<int>());

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
        int evenCount2 = BFS(0, adj2, null);
        int oddCount2 = n2 - evenCount2;
        int best2 = Math.Max(evenCount2, oddCount2);

        // Step 2: BFS на tree1, с пометкой узлов на чётных уровнях
        bool[] included = new bool[n1];
        int evenCount1 = BFS(0, adj1, included);

        // Step 3: Ответ для каждого узла в tree1
        var ans = new int[n1];
        for (int i = 0; i < n1; i++)
        {
            if (included[i])
            {
                ans[i] = evenCount1 + best2;
            }
            else
            {
                ans[i] = (n1 - evenCount1) + best2;
            }
        }

        return ans;
    }
}
```

## Complexity

> **Time complexity**: O()  
> **Space complexity**: O()