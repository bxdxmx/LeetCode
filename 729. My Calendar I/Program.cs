public class MyCalendar
{
    private readonly SortedList<int, int> list;

    public MyCalendar()
    {
        list = new SortedList<int,int>();
    }

    public bool Book(int start, int end)
    {
        int left = 0, right = list.Count - 1;

        while (left <= right)
        {
            int m = left + (right - left) / 2;
            int lStart = list.Keys[m];
            int lEnd = list[lStart];

            if (IsTimeIntersected(start, end, lStart, lEnd))
            {
                return false;
            }

            if (start > lStart)
            {
                left = m + 1;
            }
            else
            {
                right = m - 1;
            }
        }

        list.Add(start, end);

        return true;
    }

    private bool IsTimeIntersected(int start, int end, int lStart, int lEnd)
    {
        return (start >= lStart && start < lEnd) || (start < lStart && end > lStart);
    }
}
