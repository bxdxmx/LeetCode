public class Solution
{
    public bool IsHappy(int n)
    {
        bool result = true;

        while (n != 1 && result)
        {
            n = n.ToString()
                .Select(c => (int)(char.GetNumericValue(c)))
                .Select(i => i * i)
                .Sum();

            if (n == 4)
            {
                result = false;
            }
        }

        return result;
    }
}
