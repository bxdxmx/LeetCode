public class Solution
{
    // 最大でもO(50n)
    // 左にはみ出る数と右にはみ出る数を求めることで、その値が合計で何回加算対象になるかを求めている。

    public int SumOddLengthSubarrays(int[] arr)
    {
        int sum = 0;

        for (int oddLength = 1; oddLength <= arr.Length; oddLength += 2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int l = i - oddLength + 1;
                l = l > 0 ? 0 : -l;

                int r = i + oddLength - arr.Length;
                r = r < 0 ? 0 : r;

                var n = arr[i] * (oddLength - l - r);

                sum += n;
            }
        }

        return sum;
    }
}
