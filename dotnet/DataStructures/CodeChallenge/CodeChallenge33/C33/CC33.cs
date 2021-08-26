using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge33
{
  class CC33
  {
    public List<string[]> LeftJoin(Dictionary<string,string> left, Dictionary<string,string> right)
      {
      List<string[]> joined = new();

      foreach( KeyValuePair<string, string> entry in left)
      {
        if (entry.Key != null)
        {
          string[] newArr = new string[3];
          newArr[0] = entry.Key;
          newArr[1] = entry.Value;
          if (right.ContainsKey(entry.Key))
          {
            newArr[2] = right.GetValueOrDefault(entry.Key);
          }
          joined.Add(newArr);
        }
      }
      return joined;
      }
  }
}
