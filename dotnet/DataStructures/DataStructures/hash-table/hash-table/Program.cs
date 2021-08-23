using System;
using System.Collections.Generic;

namespace hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            
      string key = "U-District";
      string val = "98105";

      string key2 = "District-U";
      string val2 = "98103";

      HashTable hash = new HashTable(16);

      hash.Set(key2, val2);
      hash.Set(key, val);
      string thing = hash.Get(key);
      Console.WriteLine(thing);
        }
    }
}
