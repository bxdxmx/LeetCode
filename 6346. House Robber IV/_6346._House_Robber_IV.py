from typing import List

"""
dp[i][0]       
dp[i][1]   2   2    9   3   1
dp[i][2]            2   2   2

dp[i][0]       
dp[i][1]   2   2    9   3   1
dp[i][2]            2   2   9
dp[i][3]                    2



"""

class Solution:
    def minCapability(self, nums: List[int], k: int) -> int:
        pass




if __name__ == '__main__':
    s = Solution()
    n = s.minCapability([2,3,5,9], 2)
    print(n)
    n = s.minCapability([2,7,9,3,1], 2)
    print(n)

