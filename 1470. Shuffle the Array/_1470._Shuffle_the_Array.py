from typing import List
from itertools import chain

class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        return list(chain.from_iterable(zip(nums[:n], nums[n:])))

if __name__ == "__main__":
    s = Solution()
    print(s.shuffle([2,5,1,3,4,7], 3))
    print(s.shuffle([1,2,3,4,4,3,2,1], 4))
    print(s.shuffle([1,1,2,2], 2))

