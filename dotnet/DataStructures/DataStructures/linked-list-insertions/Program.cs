using System;
using DataStructures.Classes;

namespace DataStructures
{
    public class Program
    {
      static void Main(string[] args)
      {
        Node<int> head = new Node<int>(5); // creates node with a value
        LinkedList<int> ll = new LinkedList<int>(); //initialize linked list
        ll.Insert(6); //create a new node with a value of 6. Insert at the beginning.
        ll.Insert(7);
        ll.Print();
        bool hasNum = ll.Includes(6);
        if (hasNum == true) Console.WriteLine("Number found.");

      LinkedList<int> list1 = new LinkedList<int>();
        list1.Insert(9);
        list1.Insert(7);
        list1.Insert(5);
        list1.Insert(3);
        list1.Insert(1);
        list1.Print();


      LinkedList<int> list2 = new LinkedList<int>();
        list2.Insert(8);
        list2.Insert(6);
        list2.Insert(4);
        list2.Insert(2);
        list2.Print();


      }
      public static string ZipLists(LinkedList<int> list1, LinkedList<int> list2)
      {
        Node<int> current1 = list1.Head;
        Node<int> current2 = list2.Head;
        if (current1 == null || current2 == null)
        {
          throw new Exception("Sorry something was wrong with the lists provided");
        }
        while (current1 != null && current2 != null)
        {
          // Store list1 next Node for later usage
          Node<int> storedNext = current1.Next;

          // Point current list1 next to list 2
          current1.Next = current2;

          // move current2 forward to next position
          current2 = current2.Next;

          // move current1 forward to next position
          current1 = current1.Next;

          // Point current list1 next to stored list1 Node
          current1.Next = storedNext;

          // move current1 forward to stored position
          current1 = current1.Next;
          // loop continues until reaching the end of both lists
        }
        return list1.Print();
      }

    static void QFun()
    {
      Queue<string> myFam = new Queue<string>();

      myFam.Enqueue("Jona");
      myFam.Enqueue("Simon");
      myFam.Enqueue("Larry");
      myFam.Enqueue("Maeta");

      Console.WriteLine("----------- QUEUE-----------");

      while (myFam.Peek()) // While we are still able to peek, do this.
      {
        Node<string> person = myFam.Dequeue();
        Console.WriteLine(person);
      }
    }
  }
}
