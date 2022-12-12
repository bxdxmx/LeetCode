var s = new Solution();

Console.WriteLine(s.Reverse(123));
Console.WriteLine(s.Reverse(-123));
Console.WriteLine(s.Reverse(120));
Console.WriteLine(s.Reverse(-2147483648));


public class Solution
{
    public int Reverse(int x)
    {
        bool minus = x < 0;
        var s = x.ToString()[(minus ? 1 : 0)..];
        var reversed = new string(s.Reverse().ToArray());

        if(int.TryParse( minus ? "-" + reversed : reversed, out int result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }
}
