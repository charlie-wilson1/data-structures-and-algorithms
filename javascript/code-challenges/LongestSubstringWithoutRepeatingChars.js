var lengthOfLongestSubstring = function (s) {
  // Create array to store unique chars
  // create variable to keep track of max unique chars
  // loop through every char (c) in string.
  // If character c does not exist in the unique array, append it to the array.
  // Also, check whether or not max unique char variable is lesser than the length of the max unique char array. If it is, make maxUnique equal to length of char array + 1.

  // If char c does exist within unique array, clear the array and append the current char to it.

  let uniqueArr = [];
  let maxUnique = 0;

  for (let i = 0; i < s.length; i++) {
    if (!uniqueArr.includes(s.charAt(i))) {
      uniqueArr.push(s.charAt(i));
      if (maxUnique < uniqueArr.length) {
        maxUnique = uniqueArr.length;
      }
    } else {
      const charToRemove = uniqueArr.find((char) => char === s.charAt(i));
      let newUniqueArr = uniqueArr.slice(
        uniqueArr.indexOf(charToRemove) + 1,
        uniqueArr.length
      );
      newUniqueArr.push(s.charAt(i));
      uniqueArr = newUniqueArr;
    }
  }

  return maxUnique;
};

let s = 'Test';
lengthOfLongestSubstring(s);
