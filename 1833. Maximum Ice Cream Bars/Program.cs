public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        int res = 0;

        Array.Sort(costs);

        for(int i = 0; i < costs.Length && coins > 0; i++)
        {
            if (coins >= costs[i])
            {
                coins -= costs[i];
                res++;
            }
            else
            {
                break;
            }
        }

        return res;
    }
}
