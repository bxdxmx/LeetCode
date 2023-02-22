from typing import List


class Solution:
    def feasible(self, weights: List[int], capacity: int, days: int) -> bool:
        daysNeeded = 1
        currentLoad = 0

        for weight in weights:
            currentLoad += weight
            if currentLoad > capacity:
                daysNeeded += 1
                currentLoad = weight

        return daysNeeded <= days

    def shipWithinDays(self, weights: List[int], days: int) -> int:
        totalLoad = sum(weights)
        maxLoad = max(weights)
        left = maxLoad
        right = totalLoad

        while left < right:
            mid = (left + right) // 2

            if self.feasible(weights, mid, days):
                right = mid
            else:
                left = mid + 1

        return left


if __name__ == "__main__":
    s = Solution()
    print(s.shipWithinDays([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 5))
    print(s.shipWithinDays([3, 2, 2, 4, 1, 4], 3))
    print(s.shipWithinDays([1, 2, 3, 1, 1], 4))
