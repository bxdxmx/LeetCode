from typing import List
import math
import heapq

class Solution:
    def pickGifts(self, gifts: List[int], k: int) -> int:
        gifts = list(map(lambda x: -x, gifts))
        heapq.heapify(gifts)

        for _ in range(k):
            n = heapq.heappop(gifts)*-1
            n = math.floor(math.sqrt(n))
            heapq.heappush(gifts, -n)

        return -sum(gifts)

if __name__ == '__main__':
    s = Solution()
    n = s.pickGifts([25,64,9,4,100], 4)
    print(n)
    n = s.pickGifts([1,1,1,1], 4)
    print(n)
