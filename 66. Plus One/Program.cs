public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int i;

        for (i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] + 1 == 10)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;
                break;
            }
        }

        if (i < 0)
        {
            List<int> l = new()
            {
                1
            };
            l.AddRange(digits);
            return l.ToArray();
        }
        else
        {
            return digits;
        }
    }
}
