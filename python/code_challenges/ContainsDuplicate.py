from typing import List

class Solution:
    def ContainsDuplicate(self, nums: List[int]) -> bool:
        checkerArr = {}
        for i, num in enumerate(nums):
            # If the number that we are currently on exists within the checker array return true.
            if num in checkerArr:
                return True
            checkerArr[num] = i
        return False
