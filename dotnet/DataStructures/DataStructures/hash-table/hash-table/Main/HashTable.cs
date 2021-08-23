using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
  public class HashTable
  {

    //Initialize the linked list that will contain key value pairs. This makes up the start of the hash map.
    private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

    //First, give the number of buckets.
    public HashTable(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    // Used to find an index for the value associated with the key.
    private int Hash(string key)
    {
      int hashVal = 0;

      char[] letters = key.ToCharArray();

      // Iterate over each letter in the key.
      for(int i = 0; i < letters.Length; i++)
      {
        hashVal += letters[i];
      }

      hashVal = (hashVal * 599) % Map.Length;

      return hashVal;
    }

    public void Set(string key, string val)
    {
      // hash the key

      int hashKey = Hash(key);

      if (Map[hashKey] == null)
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, val);

      Map[hashKey].AddFirst(entry);
    }

    public bool Contains(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey !] != null)
      {
        LinkedListNode<KeyValuePair<string,string>> current = Map[hashKey].First;

        while (current != null)
        {
          if (current.Value.Key == key) { return true; }
          current = current.Next;
        }
      }
      return false;
    }

    public string Get(string key)
    {
      int hashKey = Hash(key);

      if (Map[hashKey !] != null)
      {
        LinkedListNode<KeyValuePair<string, string>> current = Map[hashKey].First;

        while (current != null)
        {
          if (current.Value.Key == key) { return current.Value.Value; }
          current = current.Next;
        }
      }
      return null;
    }

    public void Print()
    {
      for(int i = 0; i < Map.Length; i++)
      {
        Console.WriteLine($"{i} --");
        if(Map[i] != null)
        {
          LinkedListNode<KeyValuePair<string, string>> current = Map[i].First;
          while (current != null)
          {
            Console.WriteLine($"{current.Value.Key}: {current.Value.Value} =>");
            current = current.Next;
          }
        }
       Console.WriteLine();
      }
    }
  }
}
