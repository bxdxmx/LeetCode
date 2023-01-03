public class Solution
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        List<bool> res = new();

        for (int i = 0; i < l.Length; i++)
        {
            int[] subNums = nums[l[i]..(r[i] + 1)];

            Array.Sort(subNums);
            res.Add(IsArithmetic(subNums));
        }

        return res;

        bool IsArithmetic(int[] arr)
        {
            int temp = int.MinValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (temp == int.MinValue)
                {
                    temp = arr[i + 1] - arr[i];
                }
                else
                {
                    if (temp != arr[i + 1] - arr[i])
                    {
                        return false;
                    }
                }
            }

            return true;    
        }
    }
}
