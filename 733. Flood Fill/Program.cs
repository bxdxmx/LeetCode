using System.Xml.Serialization;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int m = image.Length, n = image[0].Length;
        var q = new Queue<(int y, int x)>();
        int oldColor = image[sr][sc];

        void EnqueuePixel(int y, int x)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || image[y][x] != oldColor || image[y][x] == color)
            {
                return;
            }

            q.Enqueue((y, x));
            image[y][x] = color;
        }

        EnqueuePixel(sr, sc);

        while (q.Any())
        {
            var (y, x) = q.Dequeue();

            EnqueuePixel(y, x - 1);
            EnqueuePixel(y, x + 1);
            EnqueuePixel(y - 1, x );
            EnqueuePixel(y + 1, x );
        }

        return image;
    }
}
