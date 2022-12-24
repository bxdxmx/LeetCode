public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var stack = new Stack<IList<int>>();
        stack.Push(new List<int>() { 1 });

        for (int i = 0; i < rowIndex; i++)
        {
            var prevlist = stack.Pop();
            var newList = new List<int>() { 1 };

            for (int j = 0; j < prevlist.Count - 1; j++)
            {
                newList.Add(prevlist[j] + prevlist[j + 1]);
            }

            newList.Add(1);
            stack.Push(newList);
        }

        return stack.Pop();
    }
}
