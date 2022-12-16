public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        return Array.BinarySearch(matrix.SelectMany(x => x).ToArray(), target) > -1;
    }
}
