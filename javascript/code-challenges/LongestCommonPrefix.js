let strArr = ['flower', 'flying', 'fleece'];

const containsLongestCommonPrefix = (strs) => {
  let checker = '';

  // Assign the checker to lowest amount of characters in string, thus optimizing performance
  strs.forEach((str) => {
    str.length > checker.length ? checker = str : str;
  });

  // Set variable "answer" to nothing, begin concatenating it with each char that matches
  let ans = '';

  for(let i = 0; i < checker.length; i++) {
    // if the checker value is equal to strs
    for(let s of strs) {
      if (s[i] !== checker[i]) {
        return ans;
      }
    }
    ans += checker[i];
  }
  return ans;
};


