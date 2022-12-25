public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        var s1 = new Stack<char>();
        var s2 = new Stack<char>();

        CreateStr(s, s1);
        CreateStr(t, s2);

        return s1.SequenceEqual(s2);
    }

    private void CreateStr(string str, Stack<char> stack)
    {
        foreach (var c in str)
        {
            if (c == '#')
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }
    }
}
