using System;
using CodeChallenge31.CC31;

namespace CodeChallenge31
{
    class Program
    {
        static void Main(string[] args)
        {
      string a = "Hello World I have news for you.";

      Challenge c = new Challenge();

      Console.WriteLine(c.FindMatch(a));

        }
    }
}
