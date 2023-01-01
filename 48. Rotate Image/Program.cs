public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int m = matrix.Length - 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = i; j < m- i; j++)
            {
                (
                    matrix[j][m - i],
                    matrix[m - i][m - j],
                    matrix[m - j][i],
                    matrix[i][j]
                ) = (
                        matrix[i][j],
                        matrix[j][m - i],
                        matrix[m - i][m - j],
                        matrix[m - j][i]
                    );
            }
        }
    }
}
