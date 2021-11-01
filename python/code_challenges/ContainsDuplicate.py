from typing import List

class Solution:
    def ContainsDuplicate(self, nums: List[int]) -> bool:
        checkerArr = {}
        for i, num in enumerate(nums):
            if num in checkerArr:
                return True
            checkerArr[num] = i
        return False
