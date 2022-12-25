using System.Text;

var s = new Solution();

s.DecodeString("3[a]2[bc]");

public class Solution
{
    public string DecodeString(string s)
    {
        Stack<StringBuilder> stack = new();
        Stack<int> countStack = new();

        int index = 0;
        StringBuilder res = new();

        while (index < s.Length)
        {
            if (char.IsDigit(s[index]))
            {
                int count = 0;
                while (index < s.Length && char.IsDigit(s[index]))
                {
                    count = 10 * count + (s[index++] - '0');
                }
                countStack.Push(count);
            }
            else
            {
                if (s[index] == '[')
                {
                    stack.Push(new StringBuilder());
                }
                else if (s[index] == ']')
                {
                    string segment = stack.Pop().ToString();
                    StringBuilder sb = !stack.Any() ? res : stack.Peek();
                    sb.Append(string.Concat(Enumerable.Repeat(segment, countStack.Pop())));
                }
                else
                {
                    StringBuilder sb = !stack.Any() ? res : stack.Peek();
                    sb.Append(s[index]);
                }
                index++;
            }
        }

        return res.ToString();
    }
}
