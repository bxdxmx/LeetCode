var s = new Solution();

s.NumDecodings("111111111111111111111111111111111111111111111");

public class Solution
{
    // used[i]:走査済
    // [i..i],[i..i+1]の2つを始点として走査すればOK?
    // 遅くなりそう
    // dpでやる。

    // dp[i] = 最大通り数
    // dp[i,1文字使う場合]：最後に1文字を使う場合の最大通り数
    // dp[i,2文字使う場合]：最後に2文字を使う場合の最大通り数
    // dp[i,1] = s[i] == 0 ? max(dp[i-1,1],dp[i-1,2] : dp[i-1,1] + 1
    // dp[i,2] = s[i-1] != 1or2 ? dp[i-1,2] : dp[i-1,2]+1
    // 違うか
    //  ⇒考え方はあってた
    //      dp[i,1] = dp[i-1,1] + dp[i-1,2]     // それぞれのうしろに1文字加えるパターン
    //      dp[i,2] = dp[i-1,1]                  // ひとつ前の数字を10の位、今回の文字を1の位とすればよい
    //      最後にdp[i,1]+dp[i,2]とすればよい。

    /*
     * memo化で
     * 1211
     * 
     * 1 -211 -> 2 - 11 - 1 -1 -end
     *        -> 21 - 1 - end
     * 12 -11 -> 1 -1 -end
     *        -> 11 - end
     *        
     * d[str] = 通り数を入れる
     */

    public int NumDecodings(string s)
    {
        var d = new Dictionary<string, int>();

        int SubNumDecodings(string str)
        {
            if (d.TryGetValue(str, out int value))
            {
                return value;
            }

            if (string.IsNullOrEmpty(str))
            {
                return 1;
            }

            int count =
                (str[0] != '0' ? SubNumDecodings(str[1..str.Length]) : 0) +
                ((str[0] == '1' || str[0] == '2') && str.Length >= 2 && int.Parse(str[0..2]) <= 26 ? SubNumDecodings(str[2..str.Length]) : 0);

            d[str] = count;
            return count;
        }

        return SubNumDecodings(s);
    }
}
