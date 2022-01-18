class BinarySearch
{
    //   REVIEW THIS FOR 12/04/2021
    public static int Search(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[i] )
                {
                    int temp = nums[i]
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        int ans = recursiveCall(nums, 0, nums.Length, target);

    return ans;
    }

    public static int recursiveCall(int[] nums,int start, int end, int target)
    {
    int middle = end / 2;
        if ( nums[middle] == target)
        {
            return nums[middle];
        }
        else if (target < nums[middle])
        {
      recursiveCall(nums, start, middle, target);
        }
        else
        {
      recursiveCall(nums, middle, end, target);
        }
      return -1;
    }

    public static void Main(string[] args)
    {
        // creating the number array as well as target number.
        // Call function afterward.
      int[] numArr = [5, 7, 2, 8, 10];
      int target = 5;
    }
}
