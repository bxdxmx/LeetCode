public class Solution
{
    /*
     * dp[n]:nの時の通り数を記録しておく
     * 
     * 左に0..n-1個使うときの通り数を合計すればOK　※1つはroot
     * dp[0] = 1
     * dp[1] = 1
     * 
     * n=2の時
     * [0,1],[1,0] = 1*1+1*1=2
     * 
     * n=3の時
     * [0,2],[1,1],[2,0]の3通り、⇒dp[0]*dp[2]+dp[1]*dp[1]+dp[2]*dp[0]⇒1*2+1*1+2*1=5
     * 
     * n=4の時
     * [0,3],[1,2],[2,1],[3,0] ⇒1*5+1*2+2*1+5*1=14
     */
    public int NumTrees(int n)
    {
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                dp[i] += dp[j] * dp[i - j - 1];
            }
        }

        return dp[n];
    }
}
