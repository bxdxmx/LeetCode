var s = new Solution();

s.CombinationSum4(new int[] { 1, 2, 3 }, 4);

public class Solution
{
    /*
     * dp[i]:targetがiの時の通り数
     * 
     * foreach( coin )
     * {
     *      dp[i] += dp[i - coin]   // target=i-coinの時の通り数の後ろに、現在のcoinを足したものが通り数となる
     *      dp[0] = 1;
     *      例)
     *      coinが{1,2}, target = 3の時
     *      coinが1
     *          {1,1},{2}の後ろに1を追加->{1,1,1},{2,1}
     *      coinが2
     *          {1}の後ろに2を追加->{1,2}
     * }  
     */

    public int CombinationSum4(int[] nums, int target)
    {
        int[] dp = new int[target + 1]; ;
        dp[0] = 1;

        for (int i = 0; i <= target; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                dp[i] += (i - nums[j] >= 0 ? dp[i - nums[j]] : 0);
            }
        }

        return dp[^1];
    }
}
