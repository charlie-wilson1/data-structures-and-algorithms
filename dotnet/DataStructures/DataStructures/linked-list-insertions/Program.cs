using System;
using DataStructures.Classes;

namespace DataStructures
{
    public class Program
    {
      static void Main(string[] args)
      {
        Node head = new Node(5); // creates node with a value
        LinkedList ll = new LinkedList(); //initialize linked list
        ll.Insert(6); //create a new node with a value of 6. Insert at the beginning.
        ll.Insert(7);
        ll.Print();
        bool hasNum = ll.Includes(6);
        if (hasNum == true) Console.WriteLine("Number found.");

      LinkedList list1 = new LinkedList();
        list1.Insert(9);
        list1.Insert(7);
        list1.Insert(5);
        list1.Insert(3);
        list1.Insert(1);
        Console.WriteLine(list1.Head.Value);
        list1.Print();


      LinkedList list2 = new LinkedList();
        list2.Insert(8);
        list2.Insert(6);
        list2.Insert(4);
        list2.Insert(2);
        list2.Print();

      }
      public static string ZipLists(LinkedList list1, LinkedList list2)
      {
        Node current1 = list1.Head;
        Node current2 = list2.Head;
        if (current1 == null || current2 == null)
        {
          throw new Exception("Sorry something was wrong with the lists provided");
        }
        while (current1 != null && current2 != null)
        {
          // Store list1 next Node for later usage
          Node storedNext = current1.Next;

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
    }
}
