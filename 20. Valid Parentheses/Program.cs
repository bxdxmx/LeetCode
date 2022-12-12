public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var conbi = new Dictionary<char, char>()
        {
            {')', '(' },
            {']', '[' },
            {'}', '{' }
        };

        foreach (var c in s)
        {
            if (conbi.ContainsValue(c))
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0)
                {
                    return false;
                }

                if (stack.Pop() != conbi[c])
                {
                    return false;
                }
            }
        }

        if(stack.Count != 0 )
        {
            return false;
        }

        return true;
    }
}
