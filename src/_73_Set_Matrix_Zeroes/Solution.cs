namespace _73_Set_Matrix_Zeroes;

public class Solution
{
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
}