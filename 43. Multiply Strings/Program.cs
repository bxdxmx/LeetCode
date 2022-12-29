using System.Text;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        if (num2.Length > num1.Length)
            (num1, num2) = (num2, num1);

        int len1 = num1.Length;
        int len2 = num2.Length;

        char[] chars = new char[len1 + len2];

        for (int j = len2 - 1; j >= 0; j--)
        {
            int d2 = num2[j] - '0';
            int complement = 0;
            for (int i = len1 - 1; i >= 0; i--)
            {
                int d1 = num1[i] - '0';
                int shift = j + i + 1;
                int d1cur = (chars[shift] != '\0') ? chars[shift] - '0' : 0;
                int result = d1cur + (d2 * d1) + complement;
                chars[shift] = (char)((result % 10) + '0');
                complement = result / 10;
            }
            chars[j] = (char)(complement + '0');
        }
        return new string(chars).TrimStart('0');
    }
}
