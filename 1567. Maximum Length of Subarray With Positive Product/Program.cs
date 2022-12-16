public class Solution
{
    // 0 で配列を分割
        // 分割した奴がマイナスの個数が偶数なら分割した奴の件数
        // 奇数ならmax(最初のマイナスより後の件数,最後のマイナスより前の件数）
    // それらの最大件数

    public int GetMaxLen(int[] nums)
    {
        var l = SplitByZero(nums);
        if (l.Count == 0)
        {
            return 0;
        }

        return l.Select(ns => SubGetMaxLen(ns)).Max();
    }

    private int SubGetMaxLen(List<int> list)
    {
        if (list.Count == 1 && list[0] < 0)
        {
            return 0;
        }

        int minusCount = list.Count(n => n < 0);
        int firstMinusIndex = list.FindIndex(n => n < 0);
        int lastMinusIndex = list.FindLastIndex(n => n < 0);

        if (minusCount % 2 == 0)
        {
            return list.Count;
        }
        else
        {
            return Math.Max(list.Count - (firstMinusIndex + 1), lastMinusIndex);
        }
    }

    private List<List<int>> SplitByZero(int[] nums)
    {
        var result = new List<List<int>>();
        List<int>? list = null;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (list != null)
                {
                    result.Add(list);
                    list = null;
                }
            }
            else
            {
                list ??= new List<int>();
                list.Add(nums[i]);
            }
        }

        if (list != null)
        {
            result.Add(list);
        }

        return result;
    }
}
