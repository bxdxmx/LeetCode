public class Solution
{
    private class Member
    {
        public int Score { get; set; }
        public int Age { get; set; }
    }

    public int BestTeamScore(int[] scores, int[] ages)
    {
        List<Member> members = new();

        for (int i = 0; i < scores.Length; i++)
        {
            members.Add(new Member { Score = scores[i], Age = ages[i] });
        }
        members = members.OrderBy(m => m.Age).ThenBy(m => m.Score).ToList();

        PriorityQueue<Member, int> q = new();






    }
}
