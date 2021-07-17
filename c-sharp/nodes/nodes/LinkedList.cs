using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodes
{
    class LinkedList
    {
        public Node Head { get; set; }

        //LinkedList myList = new LinkedList();
        public LinkedList(Node head) //constructor
        {
            Head = head;
        }

        public void Print() //prints out all nodes that are present.
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"( {current.Value} ) -> ");
                current = current.Next;
            }
            Console.Write("NULL\n");
        }
        public void Insert(int val) {
            Node node = new Node(val);
            if (Head != null) { // if the head value in the Linked List already exists, the next node is set to head.
                node.Next = Head; // ensuring that the new node value is put at the end of the list
            }
            Head = node; // set head value to the newly created node.
        }
        public bool Includes(int val)
        {
            Node current = Head; // set variable current to Head
            while (current != null) {
                if (current.Value == val) return true;
                current = current.Next;
            }
            return false;
        }
    }
}
