namespace _3372_Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_I;

public class Solution
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        var g2 = Build(edges2);
        var m = edges2.Length + 1;
        var t = 0;

        for (var i = 0; i < m; i++) t = Math.Max(t, Dfs(g2, i, -1, k - 1));

        var g1 = Build(edges1);
        var n = edges1.Length + 1;
        var ans = new int[n];
        Array.Fill(ans, t);

        for (var i = 0; i < n; i++) ans[i] += Dfs(g1, i, -1, k);

        return ans;
    }

    private List<int>[] Build(int[][] edges)
    {
        var n = edges.Length + 1;
        var g = new List<int>[n];
        for (var i = 0; i < n; i++) g[i] = new List<int>();

        foreach (var e in edges)
        {
            int a = e[0], b = e[1];
            g[a].Add(b);
            g[b].Add(a);
        }

        return g;
    }

    private int Dfs(List<int>[] g, int a, int fa, int d)
    {
        if (d < 0) return 0;

        var cnt = 1;
        foreach (var b in g[a])
            if (b != fa)
                cnt += Dfs(g, b, a, d - 1);

        return cnt;
    }
}