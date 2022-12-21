var s = new Solution();

var d = new int[][] {
new int[]{21,47},
new int[]{4,41},
new int[]{2,41},
new int[]{36,42},
new int[]{32,45},
new int[]{26,28},
new int[]{32,44},
new int[]{5,41},
new int[]{29,44},
new int[]{10,46},
new int[]{1,6},
new int[]{7,42},
new int[]{46,49},
new int[]{17,46},
new int[]{32,35},
new int[]{11,48},
new int[]{37,48},
new int[]{37,43},
new int[]{8,41},
new int[]{16,22},
new int[]{41,43},
new int[]{11,27},
new int[]{22,44},
new int[]{22,28},
new int[]{18,37},
new int[]{5,11},
new int[]{18,46},
new int[]{22,48},
new int[]{1,17},
new int[]{2,32},
new int[]{21,37},
new int[]{7,22},
new int[]{23,41},
new int[]{30,39},
new int[]{6,41},
new int[]{10,22},
new int[]{36,41},
new int[]{22,25},
new int[]{1,12},
new int[]{2,11},
new int[]{45,46},
new int[]{2,22},
new int[]{1,38},
new int[]{47,50},
new int[]{11,15},
new int[]{2,37},
new int[]{1,43},
new int[]{30,45},
new int[]{4,32},
new int[]{28,37},
new int[]{1,21},
new int[]{23,37},
new int[]{5,37},
new int[]{29,40},
new int[]{6,42},
new int[]{3,11},
new int[]{40,42},
new int[]{26,49},
new int[]{41,50},
new int[]{13,41},
new int[]{20,47},
new int[]{15,26},
new int[]{47,49},
new int[]{5,30},
new int[]{4,42},
new int[]{10,30},
new int[]{6,29},
new int[]{20,42},
new int[]{4,37},
new int[]{28,42},
new int[]{1,16},
new int[]{8,32},
new int[]{16,29},
new int[]{31,47},
new int[]{15,47},
new int[]{1,5},
new int[]{7,37},
new int[]{14,47},
new int[]{30,48},
new int[]{1,10},
new int[]{26,43},
new int[]{15,46},
new int[]{42,45},
new int[]{18,42},
new int[]{25,42},
new int[]{38,41},
new int[]{32,39},
new int[]{6,30},
new int[]{29,33},
new int[]{34,37},
new int[]{26,38},
new int[]{3,22},
new int[]{18,47},
new int[]{42,48},
new int[]{22,49},
new int[]{26,34},
new int[]{22,36},
new int[]{29,36},
new int[]{11,25},
new int[]{41,44},
new int[]{6,46},
new int[]{13,22},
new int[]{11,16},
new int[]{10,37},
new int[]{42,43},
new int[]{12,32},
new int[]{1,48},
new int[]{26,40},
new int[]{22,50},
new int[]{17,26},
new int[]{4,22},
new int[]{11,14},
new int[]{26,39},
new int[]{7,11},
new int[]{23,26},
new int[]{1,20},
new int[]{32,33},
new int[]{30,33},
new int[]{1,25},
new int[]{2,30},
new int[]{2,46},
new int[]{26,45},
new int[]{47,48},
new int[]{5,29},
new int[]{3,37},
new int[]{22,34},
new int[]{20,22},
new int[]{9,47},
new int[]{1,4},
new int[]{36,46},
new int[]{30,49},
new int[]{1,9},
new int[]{3,26},
new int[]{25,41},
new int[]{14,29},
new int[]{1,35},
new int[]{23,42},
new int[]{21,32},
new int[]{24,46},
new int[]{3,32},
new int[]{9,42},
new int[]{33,37},
new int[]{7,30},
new int[]{29,45},
new int[]{27,30},
new int[]{1,7},
new int[]{33,42},
new int[]{17,47},
new int[]{12,47},
new int[]{19,41},
new int[]{3,42},
new int[]{24,26},
new int[]{20,29},
new int[]{11,23},
new int[]{22,40},
new int[]{9,37},
new int[]{31,32},
new int[]{23,46},
new int[]{11,38},
new int[]{27,29},
new int[]{17,37},
new int[]{23,30},
new int[]{14,42},
new int[]{28,30},
new int[]{29,31},
new int[]{1,8},
new int[]{1,36},
new int[]{42,50},
new int[]{21,41},
new int[]{11,18},
new int[]{39,41},
new int[]{32,34},
new int[]{6,37},
new int[]{30,38},
new int[]{21,46},
new int[]{16,37},
new int[]{22,24},
new int[]{17,32},
new int[]{23,29},
new int[]{3,30},
new int[]{8,30},
new int[]{41,48},
new int[]{1,39},
new int[]{8,47},
new int[]{30,44},
new int[]{9,46},
new int[]{22,45},
new int[]{7,26},
new int[]{35,42},
new int[]{1,27},
new int[]{17,30},
new int[]{20,46},
new int[]{18,29},
new int[]{3,29},
new int[]{4,30},
new int[]{3,46}
};

Console.WriteLine(s.PossibleBipartition(50, d));

public class Solution
{
    // unin-findでAグループ、Bグループ、追加していって矛盾が生じたらfalse
    // ->違う。どちらに追加すればよいか判断できない
    // グラフを作成して、2色彩色できるかという方法で。

    public bool PossibleBipartition(int n, int[][] dislikes)
    {
        var edges = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            edges[i] = new List<int>();
        }
        var groups = new int[n]; // 0:not visited, 1:A, 2:B

        foreach (var dislike in dislikes)
        {
            int x = dislike[0] - 1;
            int y = dislike[1] - 1;

            edges[x].Add(y);
            edges[y].Add(x);
        }

        bool Part(List<int> children, int group)
        {
            foreach (int v in children)
            {
                if (groups[v] == 0)
                {
                    groups[v] = group == 1 ? 2 : 1;
                    if (!Part(edges[v], groups[v]))
                    {
                        return false;
                    }
                }
                else if (groups[v] == group)
                {
                    return false;
                }
            }

            return true;
        }

        for (int i = 0; i < edges.Length; i++)
        {
            if (groups[i] == 0)
            {
                groups[i] = 1;
            }

            if (!Part(edges[i], groups[i]))
            {
                return false;
            }
        }

        return true;
    }
}
