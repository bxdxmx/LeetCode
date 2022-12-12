var s = new Solution();
Console.WriteLine(s.FizzBuzz(3));
Console.WriteLine(s.FizzBuzz(5));
Console.WriteLine(s.FizzBuzz(15));


public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();

        for( int i = 1; i <= n; ++i )
        {
            list.Add(
                i % 15 == 0 ? "FizzBuzz" :
                i % 3 == 0 ? "Fizz" :
                i % 5 == 0 ? "Buzz" :
                i.ToString()
            );
        }

        return list;
    }
}