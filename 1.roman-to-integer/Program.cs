﻿var a = new Solution();
Console.WriteLine(a.RomanToInt("III"));
Console.WriteLine(a.RomanToInt("LVIII"));
Console.WriteLine(a.RomanToInt("MCMXCIV"));

public class Solution
{
    public int RomanToInt(string s)
    {
        int total = 0;
        char prev = '_';

        foreach( var c in s)
        {
            switch (c)
            {
                case 'I':
                    total += 1;
                    break;
                case 'V':
                    total += prev == 'I' ? 3 : 5;
                    break;
                case 'X':
                    total += prev == 'I' ? 8 : 10;
                    break;
                case 'L':
                    total += prev == 'X' ? 30 : 50;
                    break;
                case 'C':
                    total += prev == 'X' ? 80 : 100;
                    break;
                case 'D':
                    total += prev == 'C' ? 300 : 500;
                    break;
                case 'M':
                    total += prev == 'C' ? 800 : 1000;
                    break;
                default:
                    break;
            }

            prev = c;
        }

        return total;
    }
}