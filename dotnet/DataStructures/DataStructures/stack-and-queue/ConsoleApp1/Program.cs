using System;
using stackandqueue.Classes;

namespace stackandqueue
{
    class Program
    {
      static void Main(string[] args)
      {
      Queue<int> q = new Queue<int>();
      q.Enqueue(1);
      Console.WriteLine(q.Peek());
      q.Enqueue(10);

      Console.WriteLine("Dequeued val");
      Console.WriteLine(q.Dequeue());
      Console.WriteLine(q.Peek());
      q.Dequeue();
      Console.WriteLine(q.IsEmpty());
        
      }
    }
}
