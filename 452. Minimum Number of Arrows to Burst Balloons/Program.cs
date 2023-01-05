var s = new Solution();

int[][] points = new int[][]
{
    new int[]{10,16 },
    new int[]{2,8 },
    new int[]{1,6 },
    new int[]{7,12 }
};

s.FindMinArrowShots(points);

public class Solution
{
    /*
     * eの昇順でpq
     * 取得したitemのe以下のsがあれば同時に抜く
     */

    public int FindMinArrowShots(int[][] points)
    {
        PriorityQueue<(int s, int e), int> q = new();
        int res = 0;

        foreach (var point in points)
        {
            q.Enqueue((point[0], point[1]), point[1]);
        }

        while (q.Count > 0)
        {
            var point = q.Dequeue();
            res++;

            while (q.Count > 0)
            {
                if (q.Peek().s <= point.e)
                {
                    q.Dequeue();
                }
                else
                {
                    break;
                }
            }
        }

        return res;
    }
}
