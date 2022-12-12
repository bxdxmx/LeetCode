public class VersionControl
{
    public bool IsBadVersion(int version)
    {
        return true;
    }
}

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int start = 1, end = n;

        while (start < end)
        {
            int index = start + (end - start) / 2;  // (start+end)/2 だとでかい数字だとoverflowする。

            if (IsBadVersion(index))
            {
                end = index;
            }
            else
            {
                start = index + 1;
            }
        }

        return end;
    }
}
