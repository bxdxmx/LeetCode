public class Solution
{
    public bool FindRotation(int[][] mat, int[][] target)
    {
        void Rotate(int[][] matrix)
        {
            int m = matrix.Length - 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = i; j < m - i; j++)
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
    
        bool CheckEqual(int[][] matrix, int[][] target )
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != target[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        for (int i = 0; i < 4; i++)
        {
            if (CheckEqual(mat, target))
            {
                return true;
            }

            Rotate(mat);
        }

        return false;
    }
}
