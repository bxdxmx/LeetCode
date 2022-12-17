public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (new string[] { "+", "-", "*", "/" }.Contains(token))
            {
                int n1 = stack.Pop();
                int n2 = stack.Pop();

                int n = token switch
                {
                    "+" => n2+n1,
                    "-" => n2-n1,
                    "*" => n2*n1,
                    "/" => n2/n1
                };
                stack.Push(n);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
