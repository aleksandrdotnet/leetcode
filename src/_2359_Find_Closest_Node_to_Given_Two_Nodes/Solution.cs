namespace _2359_Find_Closest_Node_to_Given_Two_Nodes;

public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        var d1 = Bfs(edges, node1);
        var d2 = Bfs(edges, node2);
        
        int result = -1;
        int minMaxDist = int.MaxValue;

        for (int i = 0; i < edges.Length; i++)
        {
            if (d1[i] != -1 && d2[i] != -1)
            {
                int maxDist = Math.Max(d1[i], d2[i]);
                if (maxDist < minMaxDist || (maxDist == minMaxDist && i < result))
                {
                    minMaxDist = maxDist;
                    result = i;
                }
            }
        }

        return result;
    }

    private static int[] Bfs(int[] edges, int start)
    {
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        var result = new int[edges.Length];
        Array.Fill(result, -1);
        
        queue.Enqueue(start);
        visited.Add(start);
        result[start] = 0;
        
        var length = 0;
        while (queue.TryDequeue(out var current))
        {
            length++;
            
            if (edges[current] == -1)
            {
                return result;
            }
            
            var next = edges[current];
            if (!visited.Contains(next))
            {
                result[next] = length;
                
                queue.Enqueue(next);
                visited.Add(next);
            }
        }
        
        return result;
    }
}