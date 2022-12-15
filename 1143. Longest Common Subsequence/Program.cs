//oxcpqrsvwf
//shmtulqrypy

public class Solution
{
    // Try dynamic programming. DP[i][j] represents the longest common subsequence of text1[0 ... i] & text2[0 ... j].
    // DP[i][j] = DP[i - 1][j - 1] + 1 , if text1[i] == text2[j]
    // DP[i][j] = max(DP[i - 1][j], DP[i][j - 1]) , otherwise
    // dp[0][0] = 0

    // text1のi番目までと、text2のj番目までの文字列の最大値を記録していく。
    // 一致すれば1増やして、一致しなければ、それぞれの文字を進めたときの大きい方の値を次に引き継げばいい。


    // DP使うまでもない気がするけども
    // 両方の文字列を先頭から見ていけばいいのでは
    // ->駄目か。一致しない場合にどちらを進めればいいか判断できないから。
    // ->いや、n^2でいけるな。dpでもn^2では？
    // ->いや、やっぱ駄目だ。先頭から見ていく方式だと、途中から始めた場合の最大文字数のが検出できない。

    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[,] dp = new int[text1.Length + 1, text2.Length + 1];
        dp[0, 0] = 0;

        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                if (text1[i] == text2[j])
                {
                    dp[i + 1, j + 1] = dp[i, j] + 1;
                }
                else
                {
                    dp[i + 1, j + 1] = Math.Max(dp[i, j + 1], dp[i + 1, j]);
                }
            }
        }

        return dp[text1.Length,text2.Length];
    }

    public int LongestCommonSubsequence_NG(string text1, string text2)
    {
        int i = 0, j = 0;
        int count = 0;

        while (i < text1.Length && j < text2.Length)
        {
            if (text1[i] == text2[j])
            {
                count++;
                j++;
            }
            else
            {
                for (int j2 = j; j2 < text2.Length; j2++)
                {
                    if (text1[i] == text2[j2])
                    {
                        count++;
                        j = j2 + 1;
                        break;
                    }
                }
            }

            i++;
        }

        return count;
    }
}
