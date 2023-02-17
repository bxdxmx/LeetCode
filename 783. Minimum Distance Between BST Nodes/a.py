from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def minDiffInBST(self, root: Optional[TreeNode]) -> int:
        res = []

        @staticmethod
        def dfs(node: Optional[TreeNode]) -> None:
            if node:
                res.append(node.val)
                dfs(node.left)
                dfs(node.right)

        dfs(root)
        res.sort()

        for i in range(0, len(res) - 1):
            res[i] = res[i + 1] - res[i]

        return min(res)
