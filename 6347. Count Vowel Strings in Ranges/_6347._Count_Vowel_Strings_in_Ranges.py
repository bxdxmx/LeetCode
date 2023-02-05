from typing import List
import itertools

class Solution:
    def vowelStrings(self, words: List[str], queries: List[List[int]]) -> List[int]:
        words = [ 1 if s[0] in ('a','e','i','o','u') and s[-1] in ('a','e','i','o','u') else 0 for s in words]
        w2 = list(itertools.accumulate(words))

        res = list()

        for l, r in queries:
            res.append(w2[r]-(0 if l==0 else w2[l-1]))

        return res

if __name__ == '__main__':
    s = Solution()
    a = s.vowelStrings(["aba","bcb","ece","aa","e"], [[0,2],[1,4],[1,1]])
    print(a)
    a = s.vowelStrings(["a","e","i"], [[0,2],[0,1],[2,2]])
    print(a)

        