var r = new RandomizedSet();

r.Insert(3);
r.Insert(-2);
r.Remove(2);
r.Insert(1);
r.Insert(-3);
r.Insert(-2);
r.Remove(-2);
r.Remove(3);
r.Insert(-1);
r.Remove(-3);
r.Insert(1);
r.Insert(-2);
r.Insert(-2);
r.Insert(-2);
r.Insert(1);
r.GetRandom();
r.Insert(-2);
r.Remove(0);
r.Insert(-3);
r.Insert(1);

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
            if (val != l[count-1])
            {
                d[l[count-1]] = removeIndex;
                (l[removeIndex], l[count - 1]) = (l[count - 1], l[removeIndex]);
            }

            count--;
        }

        return res;
    }

    public int GetRandom()
    {
        return l[new Random().Next(0, count)];
    }
}
