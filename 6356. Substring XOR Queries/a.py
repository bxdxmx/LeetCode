from typing import List

class Solution:
    def substringXorQueries(self, s: str, queries: List[List[int]]) -> List[List[int]]:
        res = list()

        for query in queries:
            target = f'{query[0] ^ query[1]:b}'
            start = s.find(target)

            if start == -1:
                res.append([-1,-1])
            else:
                res.append([start,start+len(target)-1])

        return res

if __name__ == '__main__':
    s = Solution()
    print(s.substringXorQueries("101101", [[0,5],[1,2]]))
    print(s.substringXorQueries("0101", [[12,8]]))
    print(s.substringXorQueries("1", [[4,5]]))
    