var s = new Solution();

s.DuplicateZeros(new int[] { 0, 1, 2, 3, 0 });
s.DuplicateZeros(new int[] { 1, 2, 3, 0 });
s.DuplicateZeros(new int[] { 1, 0, 2, 3, 3, 4, 5, 0 });
s.DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
s.DuplicateZeros(new int[] { 0, 0, 0, 0, 0, 0, 0 });
s.DuplicateZeros(new int[] { 1, 2, 3 });

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int index = 0, indexD = 0;

        do
        {
            if (arr[index] == 0)
            {
                indexD++;
            }
            index++;
            indexD++;
        } while (indexD < arr.Length);

        for(int i=index-1, iD=indexD-1; i >= 0; --i, --iD )
        {
            if( iD < arr.Length )
            {
                arr[iD] = arr[i];
            }

            if (arr[i] == 0)
            {
                arr[--iD] = arr[i];
            }
        }
    }
}