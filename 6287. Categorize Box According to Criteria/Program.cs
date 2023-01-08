public class Solution
{
    public string CategorizeBox(int length, int width, int height, int mass)
    {
        HashSet<string> s = new();

        if (length >= 10000 || width >= 10000 || height >= 10000 || ((decimal)length * width * height) >= 1000000000)
        {
            s.Add("Bulky");
        }

        if (mass >= 100)
        {
            s.Add("Heavy");
        }

        if (s.Contains("Bulky") && s.Contains("Heavy"))
        {
            return "Both";
        }

        if (s.Count == 0)
        {
            return "Neither";
        }

        if (s.Contains("Bulky") && !s.Contains("Heavy"))
        {
            return "Bulky";
        }

        return "Heavy";
    }
}
