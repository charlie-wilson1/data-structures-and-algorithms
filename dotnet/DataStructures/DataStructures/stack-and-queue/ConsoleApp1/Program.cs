using System;
using stackandqueue.Classes;

namespace stackandqueue
{
    class Program
    {
      static void Main(string[] args)
      {

      string str = "({[()]})";

      bool ans = isValidBracket(str);

      Console.WriteLine(ans);
      }

      static bool isValidBracket(string str)
      {
        // Creating
        Stack<char> stack = new Stack<char>();
        if (str == "" || str == null) return false; 
        foreach(char c in str)
        {
          if (c == '{' || c == '(' || c == '[')
          {
            stack.Push(c);
          }
          else if (c == '}')
          {
          char temp = stack.Peek();
            if ( temp == '{')
            {
              stack.Pop();
            }
            else return false;
          }
          else if (c == ')')
          {
          char temp = stack.Peek();
            if (temp == '(')
            {
              stack.Pop();
            }
            else return false;
          }
          else if (c == ']')
          {
          char temp = stack.Peek();
            if (temp == '[')
            {
              stack.Pop();
            }
            else return false;
          }
        }
      if (stack.IsEmpty() == true) return true;
      else return false;
      }
    }
}
