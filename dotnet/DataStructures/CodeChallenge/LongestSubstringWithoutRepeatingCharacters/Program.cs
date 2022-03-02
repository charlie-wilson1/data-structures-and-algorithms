using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{

  public class Solution
  {
    public static void LongestSubstringWithoutRepeatingCharacters(string[] args)
    {
      string s = "abccdefg";
    }
    public int LengthOfLongestSubstring(string s)
    {

      // create counter variable that will keep track of longest substring
      int counter = 0;

      // create separate array that will be added to for each backwards loop and cleared at the end. 
      // The length of this array determines the amount of unique characters.

      List<int> checkerList = new List<int>();

      // loop through substring
      // if we are not on the first int of the array, loop backwards from the given int with each iteration.
      // while we are not at the very beginning of the array (within the backwards loop)

      // check whether or not the current int already exists within the list.
      // If it does, then if the list.length is greater than the current counter number we established above, make the counter the length of the list. exit out of the backwards loop.

      // else append int to the list and continue within the backwards loop until another character appears OR the backwards loop reaches the end.
      // O(n^2) is the time complexity.
      // O(n) for space.

      return counter;
    }
  }
}
