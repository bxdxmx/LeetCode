var s = new Solution();

Console.WriteLine(s.MyAtoi("9223372036854775808"));
Console.WriteLine(s.MyAtoi("1234567890123456789012345678901234567890"));
Console.WriteLine(s.MyAtoi("0032"));
Console.WriteLine(s.MyAtoi("42"));
Console.WriteLine(s.MyAtoi("   -42"));
Console.WriteLine(s.MyAtoi("4193 with words"));
Console.WriteLine(s.MyAtoi("2147483647"));
Console.WriteLine(s.MyAtoi("2147483648"));
Console.WriteLine(s.MyAtoi("-2147483648"));
Console.WriteLine(s.MyAtoi("-2147483649"));

public class Solution
{
    public int MyAtoi(string s)
    {
        var s2 = s.TrimStart();
        if (s2.Length == 0)
        {
            return 0;
        }

        int index = 0;
        bool minus = false;
        int sum = 0;

        var ci = new Dictionary<char, int>()
        {
            { '0', 0 }, { '1', 1 }, { '2', 2 },
            { '3', 3 }, { '4', 4 }, { '5', 5 },
            { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 },
        };

        switch(s2[index])
        {
            case '-':
                minus = true;
                index++;
                break;
            case '+':
                index++;
                break;
            default:
                break;
        }

        try
        {
            while (index < s2.Length)
            {
                char c = s2[index++];

                if (!Char.IsDigit(c))
                {
                    break;
                }

                sum = checked(sum * 10 + ci[c] * (minus ? -1 : 1));
            }
        }
        catch (OverflowException)
        {
            sum = minus ? int.MinValue : int.MaxValue;
        }

        return sum;
    }
}
