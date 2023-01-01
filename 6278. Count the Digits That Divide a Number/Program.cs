public class Solution
{
    public int CountDigits(int num)
    {
        int count = 0;
        int num2 = num;

        while (num2 > 0)
        {
            int n = num2 % 10;
            
            if (num % n == 0)
            {
                count++;
            }

            num2 /= 10;
        }

        return count;
    }
}
