using System;
using CodeChallenge26.Main;

namespace CodeChallenge26
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello");
      int[] test = { 8, 4, 23, 42, 16, 15 };
      Insert ins = new Insert();

     int[] res = ins.InsertionSort(test);
      foreach (int num in res)
      {
        Console.WriteLine(num);
      }
    }
  }
}
