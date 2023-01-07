var s = new Solution();

int[] gas = new int[] { 1, 2, 3, 4, 5 };
int[] cost = new int[] { 3, 4, 5, 1, 2 };

s.CanCompleteCircuit(gas, cost);

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (gas.Sum() - cost.Sum() < 0)
        {
            return -1;
        }

        int start = 0, remaining = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            remaining += gas[i] - cost[i];

            if (remaining < 0)
            {
                start = i + 1;
                remaining = 0;
            }
        }

        return start;
    }
}
