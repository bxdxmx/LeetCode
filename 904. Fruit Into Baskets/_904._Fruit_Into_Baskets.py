from typing import List
from collections import defaultdict

class Solution:
    def totalFruit(self, fruits: List[int]) -> int:
        basket = defaultdict(int)
        max_picked = 0
        left = 0
        
        for right in range(len(fruits)):
            basket[fruits[right]] += 1
            
            while len(basket) > 2:
                basket[fruits[left]] -= 1
                if basket[fruits[left]] == 0:
                    del basket[fruits[left]]
                left += 1
            
            max_picked = max(max_picked, right - left + 1)
        
        return max_picked
    
if __name__ == '__main__':
    s = Solution()
    print(s.totalFruit([1,2,1]))
    print(s.totalFruit([0,1,2,2]))
    print(s.totalFruit([1,2,3,2,2]))
