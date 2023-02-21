from typing import List


class Solution:
    def singleNonDuplicate(self, nums: List[int]) -> int:
        total = sum(map(lambda i, x: x * (-1) ** i, range(len(nums)), nums))

        return abs(total)


if __name__ == "__main__":
    s = Solution()
    print(s.singleNonDuplicate([1, 1, 2, 3, 3, 4, 4, 8, 8]))
    print(s.singleNonDuplicate([3, 3, 7, 7, 10, 11, 11]))
