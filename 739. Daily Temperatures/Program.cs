public class Solution
{
    // temp[30..100]の配列を用意
    // 後ろから見ていく
    // temp[t[i]]の値をiの値で更新する
    // t[i-1]<t[i]の時、min(t[i-1]<t[i..100])の値 - iを解とする

    // 遅い。
    // stack使用に変更

    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result= new int[temperatures.Length];
        var stack = new Stack<(int t, int i)>();

        for (int i = 0; i < temperatures.Length; ++i)
        {
            while (stack.Any())
            {
                var s = stack.Peek();
                if (s.t < temperatures[i])
                {
                    stack.Pop();
                    result[s.i] = i - s.i;
                }
                else
                {
                    break;
                }
            }

            stack.Push((temperatures[i], i));
        }

        return result;
    }

    public int[] DailyTemperatures2(int[] temperatures)
    {
        int[] tIndex = new int[71];
        int[] result = new int[temperatures.Length];
        Array.Fill(tIndex, -1);

        for (int i = temperatures.Length - 1; i >= 0; i--)
        {
            var t = temperatures[i] - 30;
            tIndex[t] = i;

            var target = tIndex.Skip(t + 1).Where(n => n != -1);
            result[i] = target.Any() ? target.Min() - i : 0;
        }

        return result;
    }

}
