public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int m = mat.Length, n = mat[0].Length;

        if( m * n != r * c )
        {
            return mat;
        }

        var re = new int[r][];
        for (int i = 0; i < r; i++)
        {
            re[i] = new int[c];
        }

        for (int i = 0; i < r * c; i++)
        {
            re[i / c][i % c] = mat[i / n][i % n];
        }

        return re;
    }
}
