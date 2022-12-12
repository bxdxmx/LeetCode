
namespace _00_ClassLibrary
{
    public class UnionFind
    {
        public int[] Parents { get; set; }

        public UnionFind(int n)
        {
            this.Parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                this.Parents[i] = i;
            }
        }

        public int Find(int x)
        {
            if (this.Parents[x] == x)
            {
                return x;
            }

            this.Parents[x] = Find(this.Parents[x]);
            return this.Parents[x];
        }

        public bool Same(int x, int y)
        {
            return this.Find(x) == this.Find(y);
        }

        public void Union(int x, int y)
        {
            x = this.Find(x);
            y = this.Find(y);

            if (x != y)
            {
                this.Parents[y] = x;
            }
        }
    }
}
