from typing import List
import bisect

class Solution:
    def countFairPairs(self, nums: List[int], lower: int, upper: int) -> int:
        nums.sort()
        res = 0
        
        for i, n in enumerate(nums[:-1]):
            if n + nums[-1] < lower:
                continue
            elif n + nums[i+1] > upper:
                break                
            
            l = bisect.bisect_left(nums, lower - n, i+1)
            r = bisect.bisect_right(nums, upper - n, i+1)
            
            res += (r-l)
        
        return res

if __name__ == '__main__':
    s = Solution()
    print(s.countFairPairs([0,1,7,4,4,5], 3, 6))
    print(s.countFairPairs([1,7,9,2,5], 11, 11))
    print(s.countFairPairs([0,0,0,0,0], 0, 0))
