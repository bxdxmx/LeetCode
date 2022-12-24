var s = new Solution();

s.Combine(5, 3);

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var list = new List<IList<int>>();

        void SubCombine(List<int> l, int s, int r)
        {
            l.Add(s);

            if (r - 1 == 0)
            {
                list.Add(new List<int>(l));
            }
            else
            {
                for (int j = s + 1; j <= n; j++)
                {
                    SubCombine(l, j, r - 1);
                }
            }

            l.RemoveAt(l.Count - 1);
        }

        for (int i = 1; i <= n; i++)
        {
            SubCombine(new List<int>(), i, k);
        }

        return list;
    }
}
