namespace _909_Snakes_and_Ladders;

public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        var flatBoard = new int [board.Length * board.Length];
        var index = 0;
        var rightToLeft = true;

        for (var i = board.Length - 1; i >= 0; i--)
        {
            for (var j = 0; j < board.Length; j++)
            {
                if (rightToLeft)
                    flatBoard[index] = rightToLeft ? board[i][j] : board[i][board.Length - 1 - j];
                else
                    flatBoard[index] = board[i][board.Length - 1 - j];

                index++;
            }

            rightToLeft = !rightToLeft;
        }
        
        var result = BFS(flatBoard, 0);
        return result;
    }

    private int BFS(int[] board, int start)
    {
        HashSet<int> visited = new();
        Queue<(int position, int step)> queue = new();

        queue.Enqueue((start, 0));
        visited.Add(start);
        
        while (queue.TryDequeue(out var item))
        {
            if (item.position >= board.Length - 1)
                return item.step;
            
            for (var dice = 1; dice <= 6; dice++)
            {
                var next = item.position + dice;
                if (next > board.Length - 1)
                    break;
                
                if (visited.Add(next))
                {
                    if (board[next] != -1)
                        next = board[next] - 1;
                    
                    queue.Enqueue((next, item.step + 1));
                }
            }
        }

        return -1;
    }
}