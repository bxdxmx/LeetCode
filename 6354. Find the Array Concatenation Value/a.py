from typing import List
from collections import deque

class Solution:
    def findTheArrayConcVal(self, nums: List[int]) -> int:
        dq = deque(nums)
        res = 0
        
        while len(dq) != 0:
            if len(dq) == 1:
                res += dq.pop()
            else:
                res += int(str(dq.popleft()) + str(dq.pop()))
        
        return res
    
if __name__ == '__main__':
    s = Solution()
    print(s.findTheArrayConcVal([7,52,2,4]))
    print(s.findTheArrayConcVal([5,14,13,8,12]))
    