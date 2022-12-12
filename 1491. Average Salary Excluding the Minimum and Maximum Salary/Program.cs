public class Solution
{
    public double Average(int[] salary)
    {
        Array.Sort(salary);
        return salary.Skip(1).SkipLast(1).Average();
    }
}
