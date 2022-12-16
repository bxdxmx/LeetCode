public class Solution
{
    // 後ろから見ていって、最大値を記録しておく
    // 今の値がそれよりも小さければOK、だめならNG
    // 配列に記録しておく。
    // 不連続だからHashで。

    // 最初のElement返さないとか。
    // O(n^3)以外で方法ある？

    // d作って、
    // 配列を左から順番に見ていって、
    // stackに格納
    // stackの先頭と自分を比較して
    // 自分の方が大きければstackから取って、d[stack] = 自分の値

    // 小さい値が出る限りstackに積んでいって、
    // 大きい値が出るとすべてはける。

    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var d = new Dictionary<int, int>();
        var s = new Stack<int>();

        foreach (int n in nums2)
        {
            while (s.Any() && s.Peek() < n)
            {
                d[s.Pop()] = n;
            }

            s.Push(n);
        }

        return nums1.Select(n => d.TryGetValue(n, out int value) ? value : -1).ToArray();
    }
}
