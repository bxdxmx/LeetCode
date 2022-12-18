public class Solution
{
    // 奇数の場合、足した後に中心を引く
    // 偶数の場合、足すだけ

    public int DiagonalSum(int[][] mat)
    {
        int n = mat.Length, m = n / 2;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += mat[i][i] + mat[n-i-1][i];
        }

        return sum + (n % 2 == 1 ? -mat[m][m] : 0);
    }
}
