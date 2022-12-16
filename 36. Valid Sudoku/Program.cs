public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool Check(int py, int px, int rn, int cn)
        {
            var s = new HashSet<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < rn; i++)
            {
                for (int j = 0; j < cn; j++)
                {
                    char c = board[py + i][px + j];

                    if (c != '.')
                    {
                        if (s.Contains(c))
                        {
                            s.Remove(c);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        return
        Check(0, 0, 1, 9) &&
        Check(1, 0, 1, 9) &&
        Check(2, 0, 1, 9) &&
        Check(3, 0, 1, 9) &&
        Check(4, 0, 1, 9) &&
        Check(5, 0, 1, 9) &&
        Check(6, 0, 1, 9) &&
        Check(7, 0, 1, 9) &&
        Check(8, 0, 1, 9) &&

        Check(0, 0, 9, 1) &&
        Check(0, 1, 9, 1) &&
        Check(0, 2, 9, 1) &&
        Check(0, 3, 9, 1) &&
        Check(0, 4, 9, 1) &&
        Check(0, 5, 9, 1) &&
        Check(0, 6, 9, 1) &&
        Check(0, 7, 9, 1) &&
        Check(0, 8, 9, 1) &&

        Check(0, 0, 3, 3) &&
        Check(0, 3, 3, 3) &&
        Check(0, 6, 3, 3) &&
        Check(3, 0, 3, 3) &&
        Check(3, 3, 3, 3) &&
        Check(3, 6, 3, 3) &&
        Check(6, 0, 3, 3) &&
        Check(6, 3, 3, 3) &&
        Check(6, 6, 3, 3);

/*
        for (int i = 0; i < n; i++)
        {
            var s = new HashSet<char>(@base);

            for (int j = 0; j < n; j++)
            {
                char c = board[i][j];

                if (c != '.')
                {
                    if (s.Contains(c))
                    {
                        s.Remove(c);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        for (int j = 0; j < n; j++)
        {
            var s = new HashSet<char>(@base);

            for (int i = 0; i < n; i++)
            {
                char c = board[i][j];

                if (c != '.')
                {
                    if (s.Contains(c))
                    {
                        s.Remove(c);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        for (int k = 0; k < n; k++)
        {
            var s = new HashSet<char>(@base);

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    char c = board[i + ((int)(k / 3)) * 3][j + (k * 3) % 9];

                    if (c != '.')
                    {
                        if (s.Contains(c))
                        {
                            s.Remove(c);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        return true;*/
    }
}
