var s = new Solution();

s.NextGreaterElement(230241);

public class Solution
{
    public int NextGreaterElement(int n)
    {
        var digits = n.ToString().ToCharArray();
        int i = digits.Length - 1;

        while (i - 1 >= 0 && digits[i] <= digits[i - 1])
        {
            i--;
        }

        if (i == 0)
        {
            return -1;
        }

        int j = i;

        while (j + 1 < digits.Length && digits[j + 1] > digits[i - 1])
        {
            j++;
        }

        (digits[i - 1], digits[j]) = (digits[j], digits[i - 1]);

        Array.Sort(digits, i, digits.Length - i);

        if (int.TryParse(string.Join("", digits), out int res))
        {
            return res;
        }
        else
        {
            return -1;
        }
    }
}
