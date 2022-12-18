public class Solution
{
    // d[i] : iの件数を格納
    // iの大きい方から走査

    public int SpecialArray(int[] nums)
    {
        var d = nums.GroupBy(n => n).ToDictionary(x => x.Key, x => x.Count());

        int greaterCount = 0;

        for (int n = d.Keys.Max(); n >= 1; n--)
        {
            greaterCount += d.TryGetValue(n, out int value) ? value : 0;

            if (greaterCount == n)
            {
                return greaterCount;
            }
            else if (greaterCount > n)
            {
                break;
            }
        }

        return -1;
    }
}
