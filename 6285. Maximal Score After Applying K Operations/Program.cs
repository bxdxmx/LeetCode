public class Solution
{
    public long MaxKelements(int[] nums, int k)
    {
        long maxScore = 0;
        PriorityQueue<int, int> q = new();

        for (int i = 0; i < nums.Length; i++)
        {
            q.Enqueue(nums[i], int.MaxValue - nums[i]);
        }

        for (int i = 0; i < k; i++)
        {
            int n = q.Dequeue();
            maxScore += n;

            int newN = (int)Math.Ceiling(n / 3.0);

            q.Enqueue(newN, int.MaxValue - newN);
        }

        return maxScore;
    }
}
