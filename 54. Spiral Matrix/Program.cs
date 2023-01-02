public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        (int v, int h)[] direction = { (0, 1), (1, 0), (0, -1), (-1, 0) };
        (int v, int h) curr = (0, 0);
        int d = 0;
        List<int> res = new();

        while (true)
        {
            res.Add(matrix[curr.v][curr.h]);
            matrix[curr.v][curr.h] = int.MinValue;

            if (AllVisited(curr.v, curr.h))
            {
                break;
            }

            Forward();
        }

        return res;

        bool AllVisited(int v, int h)
        {
            if (
                (v - 1 < 0 || matrix[v - 1][h] == int.MinValue) &&
                (v + 1 >= m || matrix[v + 1][h] == int.MinValue) &&
                (h - 1 < 0 || matrix[v][h - 1] == int.MinValue) &&
                (h + 1 >= n || matrix[v][h + 1] == int.MinValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void Forward()
        {
            int v = curr.v + direction[d].v;
            int h = curr.h + direction[d].h;

            if (v < 0 || v >= m || h < 0 || h >= n || matrix[v][h] == int.MinValue)
            {
                d = (d + 1) % 4;
                curr.v += direction[d].v;
                curr.h += direction[d].h;
            }
            else
            {
                curr.v = v;
                curr.h = h;
            }
        }
    }
}
