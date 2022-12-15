public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>>();
        list.Add(new List<int>() { 1 });

        for (int i = 2; i <= numRows; i++)
        {
            var prevlist = list[i - 2];
            var newList = new List<int>() { 1 };

            for (int j = 0; j < prevlist.Count - 1; j++)
            {
                newList.Add(prevlist[j] + prevlist[j + 1]);
            }

            newList.Add(1);
            list.Add(newList);
        }

        return list;
    }
}
