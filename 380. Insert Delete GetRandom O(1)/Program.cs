var r = new RandomizedSet();

r.Insert(1);
r.Remove(2);
r.Insert(2);
r.GetRandom();
r.Remove(1);
r.Insert(2);
r.GetRandom();

public class RandomizedSet
{
    private readonly Dictionary<int,int> d;
    private readonly List<int> l;
    private int count;

    public RandomizedSet()
    {
        d = new Dictionary<int, int>();
        l = new List<int>();
    }

    public bool Insert(int val)
    {
        bool res = d.ContainsKey(val);

        if (!res)
        {
            if (count == l.Count)
            {
                l.Add(val);
            }
            else
            {
                l[count] = val;
            }

            d[val] = count;
            count++;
        }

        return !res;
    }

    public bool Remove(int val)
    {
        bool res = d.ContainsKey(val);

        if (res)
        {
            int removeIndex = d[val];
            d.Remove(val);
            d[l[^1]] = removeIndex;

            (l[removeIndex], l[^1]) = (l[^1], l[removeIndex]);
            
            count--;
        }

        return res;
    }

    public int GetRandom()
    {
        return l[new Random().Next(0, count)];
    }
}
