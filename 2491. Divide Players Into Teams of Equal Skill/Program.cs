
var s = new Solution();

Console.WriteLine(s.DividePlayers(new int[] { 3, 2, 5, 1, 3, 4 }));
Console.WriteLine(s.DividePlayers(new int[] { 3, 4}));
Console.WriteLine(s.DividePlayers(new int[] { 1,1,2,3}));
Console.WriteLine(s.DividePlayers(new int[] { 2,4, 1,3}));


public class Solution
{
    public long DividePlayers(int[] skill)
    {
        if (skill.Length == 2)
        {
            return skill[0] * skill[1];
        }

        Array.Sort(skill);

        long p = 0;
        int prev = -1;

        for (int i = 0, j = skill.Length - 1; i < skill.Length && i < j; i++, j--)
        {
            if (prev != -1 && skill[i] + skill[j] != prev)
            {
                return -1;
            }

            prev = skill[i] + skill[j];
            p += skill[i] * skill[j];
        }

        return p;
    }
}
