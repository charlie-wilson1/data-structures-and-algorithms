var threeSum = (nums) => {
  nums.sort((a, b) => a - b);
  var ansArr = [];
  for (let i = 0; i < nums.length; i++) {
    //make sure i does not have a duplicate value.
    if (i > 0 && nums[i] === nums[i - 1]) continue;

    //value that should be reached when left and right are added together.
    const target = 0 - nums[i];

    // Establish a left amount as 1 step ahead of i.
    // Establish right amount as the length of nums - 1 (to account for 0 index);
    let left = i + 1;
    let right = nums.length - 1;

    while (right > left) {
      // while left and right have not intersected

      // Establish the sum of left and right
      const sum = nums[left] + nums[right];

      // If sum is greater, we must reduce total amount. decrement right.
      if (sum > target) {
        right--;
      }
      //opposite for left.
      else if (sum < target) {
        left++;
      }
      // if we have found our target, add the solution set to sub array.
      else {
        let subArr = [];
        subArr.push(nums[i], nums[left], nums[right]);
        ansArr.push(subArr);

        // We cannot have duplicate values in left and right at any point as well. c
        //check against this and decrement/increment as necessary.
        while (nums[left] === nums[left + 1]) left++;
        while (nums[right] === nums[right - 1]) right--;
        left++;
        right--;
      }
    }
  }
  return ansArr;
};