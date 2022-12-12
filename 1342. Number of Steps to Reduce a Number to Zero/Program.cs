var s = new Solution();

Console.WriteLine(s.NumberOfSteps(14));
Console.WriteLine(s.NumberOfSteps(8));
Console.WriteLine(s.NumberOfSteps(123));


public class Solution
{
    public int NumberOfSteps(int num)
    {
        int cnt = num == 0 ? 0 : -1;

        while(num > 0)
        {
            cnt += (num & 1)+1;
            num >>= 1;
        }

        return cnt;
    }
}