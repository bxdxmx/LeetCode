/*
  * dp[i,j] = (0,0)..(i,j)の合計値
  * dp[i,j] = dp[i-1,j] + dp[i,j-1] - dp[i-1,j-1] + mat[i,j]
  * 
  * r[i,j] = dp[i+k,j+k] - dp[i-k-1,j+k] - dp[i+k,j-k-1] + dp[i-k-1,j-k-1]
  */

using System;

public class NumMatrix
{
    private int[,] dp;

    public NumMatrix(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        dp = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] =
                    (i - 1 >= 0 ? dp[i - 1, j] : 0) +
                    (j - 1 >= 0 ? dp[i, j - 1] : 0) -
                    (i - 1 >= 0 && j - 1 >= 0 ? dp[i - 1, j - 1] : 0) +
                    matrix[i][j];
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        return
            dp[row2, col2] -
            (row1 - 1 >= 0 ? dp[row1 - 1, col2] : 0) -
            (col1 - 1 >= 0 ? dp[row2, col1 - 1] : 0) +
            (row1 - 1 >= 0 && col1 - 1 >= 0 ? dp[row1 - 1, col1 - 1] : 0);
    }
}
