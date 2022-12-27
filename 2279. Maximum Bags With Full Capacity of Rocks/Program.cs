

int[] c = new int[] { 91, 54, 63, 99, 24, 45, 78 };
int[] r = new int[] { 35, 32, 45, 98, 6, 1, 25 };
int a = 17;

var s = new Solution();
s.MaximumBags(c, r, a);


public class Solution
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        int n = capacity.Length;

        for (int i = 0; i < n; i++)
        {
            capacity[i] -= rocks[i];
        }

        Array.Sort(capacity);

        int maxnum = 0;

        while (additionalRocks > 0 && maxnum < n)
        {
            if (capacity[maxnum] == 0)
            {
                maxnum++;
            }
            else if(capacity[maxnum] <= additionalRocks)
            {
                additionalRocks -= capacity[maxnum];
                capacity[maxnum] = 0;
                maxnum++;
            }
            else
            {
                break;
            }
        }

        return maxnum;
    }
}
