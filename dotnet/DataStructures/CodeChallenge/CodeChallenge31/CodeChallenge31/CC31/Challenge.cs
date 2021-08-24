using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge31.CC31
{
  public class Challenge
  {
    public string FindMatch(string startingString)
    {

      Hashtable hashtable = new Hashtable(30);

      string[] strArr = startingString.Split(" ");
      foreach(string str in strArr)
      {
        if (hashtable.Contains(str))
        {
          return str;
        }

        //Add both the key and the val to the hashmap.
        hashtable.Add(str, str);
      }
      return null;
    }
  }
}
