public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int res = 0;

        for (int j = 0; j < strs[0].Length; j++)
        {
            for (int i = 0; i < strs.Length-1; i++)
            {
                if (strs[i][j] > strs[i + 1][j])
                {
                    res++;
                    break;
                }
            }
        }

        return res;
    }
}
