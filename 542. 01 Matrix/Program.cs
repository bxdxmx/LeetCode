/*
 * Given an m x n binary matrix mat, return the distance of the nearest 0 for each cell.
    The distance between two adjacent cells is 1
 */

var s = new Solution();
int[][] mat = new int[3][];
mat[0] = new int[3] { 0, 0, 0 };
mat[1] = new int[3] { 0, 1, 0 };
mat[2] = new int[3] { 1, 2, 1 };

s.UpdateMatrix(mat);


public class Solution
{
    // 順番に見ていけばOK
    // 一回見たところは確定値を入れておく
    // ->遅かったのでやり方をかえる。
    // 
    // 確実に確定したものしか見ないようにする
    // DP的に。
    // 距離0の周りを1に更新する。
    // 次に、距離1の周りを2に更新する。　※更新対象の距離がより小さい場合は更新対象外
    // 全部更新完了したら終了

    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[][] result = new int[m][];
        for (int y = 0; y < m; y++)
        {
            result[y] = new int[n];

            for (int x = 0; x < n; x++)
            {
                if (mat[y][x] != 0)
                {
                    result[y][x] = int.MaxValue;
                }
            }
        }

        void SubUpdateMatrix(int y, int x, int d)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || result[y][x] <= d)
            {
                return;
            }

            result[y][x] = d;
        }

        int d = 0;

        while (true)
        {
            bool isUpdate = false;

            for (int y = 0; y < m; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (result[y][x] == d)
                    {
                        isUpdate = true;

                        SubUpdateMatrix(y - 1, x, d + 1);
                        SubUpdateMatrix(y + 1, x, d + 1);
                        SubUpdateMatrix(y, x - 1, d + 1);
                        SubUpdateMatrix(y, x + 1, d + 1);
                    }
                }
            }

            if (isUpdate == false)
            {
                break;
            }

            d++;
        }

        return result;
    }


    // ちょっと遅い。
    public int[][] UpdateMatrix2(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[][] result = new int[m][];
        for (int y = 0; y < m; y++)
        {
            result[y] = new int[n];

            for (int x = 0; x < n; x++)
            {
                result[y][x] = mat[y][x] == 0 ? 0 : int.MaxValue;
            }
        }

        void SubUpdateMatrix(int y, int x, int d)
        {
            if (x < 0 || x >= n || y < 0 || y >= m || result[y][x] <= d)
            {
                return;
            }

            result[y][x] = d;

            SubUpdateMatrix(y - 1, x, d + 1);
            SubUpdateMatrix(y + 1, x, d + 1);
            SubUpdateMatrix(y, x - 1, d + 1);
            SubUpdateMatrix(y, x + 1, d + 1);
        }

        for (int y = 0; y < m; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (mat[y][x] == 0)
                {
                    SubUpdateMatrix(y - 1, x, 1);
                    SubUpdateMatrix(y + 1, x, 1);
                    SubUpdateMatrix(y, x - 1, 1);
                    SubUpdateMatrix(y, x + 1, 1);
                }
            }
        }

        return result;
    }
}