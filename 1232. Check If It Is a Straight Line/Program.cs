public class Solution
{
    // parameterは昇順とは限らないのか。[
    // 傾きの一致をみるべきか
    // 距離の一致をみる

    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length == 2)
        {
            return true;
        }

        const double E = 0.00001;

        var Distance = (int[] d1, int[] d2) => Math.Sqrt((Math.Pow(d1[0] - d2[0], 2) + Math.Pow(d1[1] - d2[1], 2)));
 
        for (int i = 2; i < coordinates.Length; i++)
        {
            var p0 = coordinates[i - 0];
            var p1 = coordinates[i - 1];
            var p2 = coordinates[i - 2];

            var d01 = Distance(p0, p1);
            var d12 = Distance(p1, p2);
            var d20 = Distance(p2, p0);

            if (d01 + d12 - d20 > E &&
                d12 + d20 - d01 > E &&
                d20 + d01 - d12 > E)
            {
                return false;
            }
        }

        return true;
    }
}
