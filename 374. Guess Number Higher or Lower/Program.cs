/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class GuessGame
{
    public int guess(int num)
    {
        return 0;
    }
}

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int start = 1, end = n;

        while (start < end)
        {
            int index = start + (end - start) / 2;
            int num = guess(index);

            if (num == 0)
            {
                return index;
            }
            else if (num == -1)
            {
                end = index;
            }
            else
            {
                start = index + 1;
            }
        }

        return end;
    }
}
