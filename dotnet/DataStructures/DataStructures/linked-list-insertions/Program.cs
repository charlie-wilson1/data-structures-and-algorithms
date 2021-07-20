using System;
using DataStructures.Classes;

namespace DataStructures
{
    class Program
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
      }
    }
}
