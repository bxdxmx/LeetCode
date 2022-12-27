public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int index = haystack.IndexOf(needle);

        return index < 0 ? -1 : index;
    }
}
