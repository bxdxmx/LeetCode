from typing import List
import heapq


class Solution:
    def minimumDeviation(self, nums: List[int]) -> int:
        pq = [-num * 2 if num % 2 == 1 else -num for num in nums]
        min_val = -max(pq)
        heapq.heapify(pq)

        min_deviation = float("inf")

        while True:
            max_val = -heapq.heappop(pq)
            min_deviation = min(min_deviation, max_val - min_val)
            if max_val % 2 == 1:
                break

            max_val //= 2
            min_val = min(min_val, max_val)
            heapq.heappush(pq, -max_val)

        return min_deviation


if __name__ == "__main__":
    s = Solution()
    print(s.minimumDeviation([1, 2, 3, 4]))
    print(s.minimumDeviation([4, 1, 5, 20, 3]))
