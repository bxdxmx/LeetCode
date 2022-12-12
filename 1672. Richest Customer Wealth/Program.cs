public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int result = 0;

        for(int i=0; i<accounts.Length; ++i)
        {
            int sum = accounts[i].Sum();
            if( result < sum )
            {
                result = sum;
            }
        }

        return result;
    }
}