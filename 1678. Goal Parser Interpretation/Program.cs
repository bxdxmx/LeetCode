public class Solution
{
    public string Interpret(string command)
    {
        return command.Replace("(al)", "al").Replace("()", "o");
    }
}
