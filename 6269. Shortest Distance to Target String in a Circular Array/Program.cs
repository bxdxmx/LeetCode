public class Solution
{
    public int ClosetTarget(string[] words, string target, int startIndex)
    {
        int n = words.Length;

        if (Array.IndexOf(words, target) < 0)
        {
            return -1;
        }

        int i = startIndex, j = startIndex;
        int count = 0;

        while (true)
        {
            if (words[i] == target || words[j] == target)
            {
                break;
            }

            i = (i + 1) % n;
            j = (j - 1 + n) % n;
            count++;
        }

        return count;
    }
}
