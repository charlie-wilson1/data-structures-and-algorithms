class Solution(object):
    def minCostClimbingStairs(self, cost):
        """
        :type cost: List[int]
        :rtype: int
        """
        cost.append(0)
        # iterate backwards, starting on the length of cost minus 3, going back -1 each time until hitting -1.
        # in the case of [10, 15, 20] 0
        for i in range(len(cost) - 3, -1, -1):
            # whichever one is smaller (15 + 20 or 15 + 0 for the first case)
            cost[i] += min(cost[i + 1], cost[i + 2])
            
        return min(cost[0], cost[1])