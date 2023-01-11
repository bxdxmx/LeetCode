public interface NestedInteger
{
    bool IsInteger();

    int GetInteger();

    IList<NestedInteger> GetList();
}
 
public class NestedIterator
{
    private readonly Queue<int> q = new();

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        foreach (NestedInteger nestedInteger in nestedList)
        {
            Flatten(nestedInteger);
        }

        void Flatten(NestedInteger nestedInteger)
        {
            if (nestedInteger.IsInteger())
            {
                q.Enqueue(nestedInteger.GetInteger());
            }
            else
            {
                foreach (NestedInteger nestedList in nestedInteger.GetList())
                {
                    Flatten(nestedList);
                }
            }
        }
    }

    public bool HasNext()
    {
        return q.Any();
    }

    public int Next()
    {
        return q.Dequeue();
    }
}
