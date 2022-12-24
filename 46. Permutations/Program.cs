public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        Array.Sort(nums);
        return AllPermutation(nums);
    }

    public static List<IList<T>> AllPermutation<T>(params T[] array) where T : IComparable
    {
        var list = new List<T>(array);
        var res = new List<IList<T>>
        {
            new List<T>(list)
        };
        var n = list.Count;
        var next = true;
        while (next)
        {
            next = false;

            int i;
            for (i = n - 2; i >= 0; i--)
            {
                if (list[i].CompareTo(list[i + 1]) < 0)
                {
                    break;
                }
            }

            if (i < 0)
            {
                break;
            }

            var j = n;
            do
            {
                j--;
            } while (list[i].CompareTo(list[j]) > 0);

            if (list[i].CompareTo(list[j]) < 0)
            {
                (list[j], list[i]) = (list[i], list[j]);
                list.Reverse(i + 1, n - i - 1);
                res.Add(new List<T>(list));
                next = true;
            }
        }

        return res;
    }
}
