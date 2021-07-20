using System;

namespace DataStructures.Classes 
{
    public class Node // very similar to c++ classes. can assign values as well as a constructor.
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node (int value ) // constructor for node that allows you to set the value.
        {
            Value = value;
        }
    // example: Node mynode = new Node(5); this can be used in other class definitions.
    }
}
