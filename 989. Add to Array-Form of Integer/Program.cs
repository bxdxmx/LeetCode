var s = new Solution();

s.AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);

public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        int carry = 0;
        Stack<int> s = new();
        Stack<int> res = new();

        foreach (int n in num)
        {
            s.Push(n);
        }

        while (k > 0 || s.Any())
        {
            (k, int n) = (k / 10, k % 10);
            int sum = (s.Any() ? s.Pop() : 0) + n + carry;

            carry = sum / 10;
            res.Push(sum % 10);
        }

        if (carry != 0)
        {
            res.Push(carry);
        }

        return res.ToList();
    }
}
