public class Solution
{
    public int CountOdds(int low, int high)
    {
        int d = high - low;
        return (low & 1) == 1 || (high & 1) == 1 ? d / 2 + 1 : d / 2;
    }
}
