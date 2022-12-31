var s = new Solution();

int[][] grid = new int[][]
{
    new int[]{1,0,0,0 },
    new int[]{0,0,0,0 },
    new int[]{0,0,2,-1 }
};

s.UniquePathsIII(grid);

public class Solution
{
    /*
     * DFSで。
     * 
     * counter.
     * 
     * not-visited-counterが0の時にgoalにつけばcounter++
     * 
     * visited = -2
     * 
     */
    public int UniquePathsIII(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;

        int notVisitedCounter = 0, si = 0, sj = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    notVisitedCounter++;
                }
                else if (grid[i][j] == 1)
                {
                    notVisitedCounter++;
                    si = i;
                    sj = j;
                }
            }
        }

        int res = 0;

        void DFS( int i, int j)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == -1 || grid[i][j] == -2)
            {
                return;
            }

            if (grid[i][j] == 2)
            {
                if (notVisitedCounter == 0)
                {
                    res++;
                }

                return;
            }

            grid[i][j] = -2;
            notVisitedCounter--;

            DFS(i - 1, j);
            DFS(i + 1, j);
            DFS(i, j - 1);
            DFS(i, j + 1);

            grid[i][j] = 0;
            notVisitedCounter++;
        }

        DFS(si, sj);

        return res;
    }
}
