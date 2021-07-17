using System;

namespace nodes
{
    class Program
    {
      static void Main(string[] args)
      {
      Node head = new Node(5); // creates node with a value
      LinkedList ll = new LinkedList(head); //initialize linked list
      ll.Insert(6); //create a new node with a value of 6. Insert at the beginning.
      ll.Insert(7);
      ll.Print();
      bool hasNum = ll.Includes(6);
      if (hasNum == true) Console.WriteLine("Number found.");
      else Console.WriteLine("Number not found.");
      }
    }
}
