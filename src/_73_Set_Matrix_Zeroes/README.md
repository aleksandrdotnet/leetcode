# 73. Set Matrix Zeroes

![Complexity](https://img.shields.io/badge/medium-yellow)
![Topics](https://img.shields.io/badge/array-blue)
![Topics](https://img.shields.io/badge/hash_table-blue)
![Topics](https://img.shields.io/badge/matrix-blue)

[73. Set Matrix Zeroes](https://leetcode.com/problems/set-matrix-zeroes/description/?envType=daily-question&envId=2025-05-21)

```
Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

You must do it in place.
```

## Example 1
![png](Resources/73_1.jpg)
```
Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]
```

## Example 2
![png](Resources/73_2.jpg)
```
Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
```

## Constraints
```
m == matrix.length
n == matrix[0].length
1 <= m, n <= 200
-2^31 <= matrix[i][j] <= 2^31 - 1
```

# Follow up
```
A straightforward solution using O(mn) space is probably a bad idea.
A simple improvement uses O(m + n) space, but still not the best solution.
Could you devise a constant space solution?
```

## Code
```csharp
public void SetZeroes(int[][] matrix)
{
    var rowLength = matrix.Length;
    var colLength = matrix[0].Length;

    var rows = new int[rowLength];
    var columns = new int[colLength];

    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            if (matrix[i][j] == 0)
            {
                rows[i] = 21052024;
                columns[j] = 21052024;
            }
        }
    }

    for (var i = 0; i < rowLength; i++)
    for (var j = 0; j < colLength; j++)
        if (rows[i] == 21052024 || columns[j] == 21052024)
            matrix[i][j] = 0;
}
```

## Complexity
> **Time complexity**: O(m * n)  
> **Space complexity**: O(m + n)