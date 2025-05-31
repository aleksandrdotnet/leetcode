# 909. Snakes and Ladders

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/breadth_first_search-blue)
![Topics](https://img.shields.io/badge/matrix-blue)

[909. Snakes and Ladders](https://leetcode.com/problems/snakes-and-ladders/description/?envType=daily-question&envId=2025-05-31)

```
You are given an n x n integer matrix board where the cells are labeled from 1 to n2 in a Boustrophedon style starting from the bottom left of the board (i.e. board[n - 1][0]) and alternating direction each row.

You start on square 1 of the board. In each move, starting from square curr, do the following:

Choose a destination square next with a label in the range [curr + 1, min(curr + 6, n2)].
This choice simulates the result of a standard 6-sided die roll: i.e., there are always at most 6 destinations, regardless of the size of the board.
If next has a snake or ladder, you must move to the destination of that snake or ladder. Otherwise, you move to next.
The game ends when you reach the square n2.
A board square on row r and column c has a snake or ladder if board[r][c] != -1. The destination of that snake or ladder is board[r][c]. Squares 1 and n2 are not the starting points of any snake or ladder.

Note that you only take a snake or ladder at most once per dice roll. If the destination to a snake or ladder is the start of another snake or ladder, you do not follow the subsequent snake or ladder.

For example, suppose the board is [[-1,4],[-1,3]], and on the first move, your destination square is 2. You follow the ladder to square 3, but do not follow the subsequent ladder to 4.
Return the least number of dice rolls required to reach the square n2. If it is not possible to reach the square, return -1.
```

## Example 1

![png](Resources/909_1.png)

```
Input: board = [[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[-1,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]
Output: 4
Explanation: 
In the beginning, you start at square 1 (at row 5, column 0).
You decide to move to square 2 and must take the ladder to square 15.
You then decide to move to square 17 and must take the snake to square 13.
You then decide to move to square 14 and must take the ladder to square 35.
You then decide to move to square 36, ending the game.
This is the lowest possible number of moves to reach the last square, so return 4.
```

## Example 2

```
Input: board = [[-1,-1],[-1,3]]
Output: 1
```

## Constraints

```
n == board.length == board[i].length
2 <= n <= 20
board[i][j] is either -1 or in the range [1, n^2].
The squares labeled 1 and n2 are not the starting points of any snake or ladder.
```

## Code

```csharp
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
```

## Complexity

> **Time complexity**: O(n^2)  
> **Space complexity**: O(n^2)