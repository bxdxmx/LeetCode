public class Solution
{
    public int ArraySign(int[] nums)
    {
        int signFunc(int n) => n == 0 ? 0 : n > 0 ? 1 : -1;
        return nums.Select(n => signFunc(n)).Aggregate(1, (a, b) => a * b);
    }
}
