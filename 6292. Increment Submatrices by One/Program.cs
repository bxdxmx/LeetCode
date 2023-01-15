public class Solution
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        int[][] mat = new int[n][];

        for (int i = 0; i < mat.Length; i++)
        {
            mat[i] = new int[n];
        }

        foreach (int[] query in queries)
        {
            for (int i = query[0]; i <= query[2]; i++)
            {
                for (int j = query[1]; j <= query[3]; j++)
                {
                    mat[i][j]++;
                }
            }
        }

        return mat;
    }
}
