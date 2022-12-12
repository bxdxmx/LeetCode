namespace _00_ClassLibrary
{
    public class Class1
    {
        /// <summary>
        /// Permutation生成（Yield）
        /// 遅いけど汎用的なやつ
        /// 10要素で25730ms
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> Permutate<T>(IEnumerable<T> items)
        {
            if (!items.Any())
            {
                yield return Enumerable.Empty<T>();
            }
            else
            {
                foreach (var item in items)
                {
                    var remainingItems = items.Except(new[] { item });
                    foreach (var permutationOfRemainingItems in Permutate(remainingItems))
                    {
                        yield return permutationOfRemainingItems.Prepend(item);
                    }
                }
            }
        }

        /// <summary>
        /// Permutation生成
        /// 速いけど昇順に並べている必要があるやつ
        /// 10要素で848ms
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static List<T[]> AllPermutation<T>(params T[] array) where T : IComparable
        {
            var a = new List<T>(array).ToArray();
            var res = new List<T[]>();
            res.Add(new List<T>(a).ToArray());
            var n = a.Length;
            var next = true;
            while (next)
            {
                next = false;

                // 1
                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) break;
                }
                // 2
                if (i < 0) break;

                // 3
                var j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    // 4
                    var tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    Array.Reverse(a, i + 1, n - i - 1);
                    res.Add(new List<T>(a).ToArray());
                    next = true;
                }
            }
            return res;
        }

        /// <summary>
        /// Permutation生成（yield版）
        /// 速いけど昇順に並べている必要があるやつ
        /// 10要素で1100ms
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> AllPermutationYield<T>(IEnumerable<T> items) where T : IComparable
        {
            var a = new List<T>(items);
            yield return new List<T>(a);
            int n = a.Count;
            bool next = true;
            while (next)
            {
                next = false;

                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) break;
                }
                if (i < 0) break;

                int j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    (a[j], a[i]) = (a[i], a[j]);
                    a.Reverse(i + 1, n - i - 1);
                    yield return new List<T>(a);
                    next = true;
                }
            }
        }

        /// <summary>
        /// combination(yield)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> Combination<T>(IEnumerable<T> items, int n)
        {
            return Enumerable.Range(0, n - 1)
                .Aggregate(
                    Enumerable.Range(0, items.Count() - n + 1)
                        .Select(num => new List<int> { num }),
                    (list, _) => list.SelectMany(
                        c =>
                            Enumerable.Range(c.Max() + 1, items.Count() - c.Max() - 1)
                                .Select(num => new List<int>(c) { num })
                    )
                )
                .Select(
                    c => c.Select(num => items.ElementAt(num))
                );
        }
    }
}
