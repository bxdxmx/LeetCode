using System.Text;

var s = new Solution();

Console.WriteLine(s.Convert("PAYPALISHIRING", 3));
Console.WriteLine(s.Convert("PAYPALISHIRING", 4));

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if( numRows == 1 )
        {
            return s;
        }

        var sbs = new StringBuilder[numRows];

        for( int j = 0; j < numRows; j++ )
        {
            sbs[j] = new StringBuilder(s.Length / numRows);
        }

        bool down = true;
        int i = 0;

        foreach (var c in s)
        {
            sbs[i].Append(c);

            if(down)
            {
                if( i + 1 == numRows )
                {
                    down = false;
                    i--;
                }
                else
                {
                    i++;
                }
            } 
            else
            {
                if( i == 0 )
                {
                    down = true;
                    i++;
                }
                else
                {
                    i--;
                }
            }
        }

        return string.Join("", sbs.Select(s => s.ToString()));
    }
}
