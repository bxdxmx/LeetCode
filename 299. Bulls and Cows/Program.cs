using System.Text;

var s = new Solution();

s.GetHint("1123", "0111");

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        int countA = 0, countB = 0;

        var sbSecret = new StringBuilder(secret);
        var sbGuess = new StringBuilder(guess);

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                countA++;
                sbSecret[i] = '_';
                sbGuess[i] = '_';
            }
        }

        var dSecret = new Dictionary<char, int>();
        var dGuess = new Dictionary<char, int>();
        dSecret['_'] = 0;
        dGuess['_'] = 0;

        for (char c = '0'; c <= '9'; c++)
        {
            dSecret[c] = 0;
            dGuess[c] = 0;
        }

        for (int i = 0; i < sbSecret.Length; i++)
        {
            dSecret[sbSecret[i]]++;
            dGuess[sbGuess[i]]++;
        }

        for (char c = '0'; c <= '9'; c++)
        {
            countB += Math.Min(dSecret[c], dGuess[c]);
        }

        return countA.ToString() + 'A' + countB.ToString() +'B';
    }
}
