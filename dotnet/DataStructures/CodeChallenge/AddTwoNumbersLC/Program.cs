using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge18.Classes;

namespace AddTwoNumbersLC
{
  class Node<T>
  {
    public int val;

    public Node<T> next;

    public Node(int val=0, Node<T> next=null)
    {
      this.val = val;
      this.next = next;
    }
  }
    class Program
    {
        static void Main(string[] args)
        {

        }

    // NAIVE SOLUTION
      static Node<int> AddTwoNumbers(Node<int> node, Node<int> node2)
      {
        int index = 0;
        int carryOver = 0;
        Node<int> sumNode = new();

      // While both node 1 and 2's next are not null..
      while (node.next != null && node2.next != null)
      {

        // If either side is null..
        if (node.next == null)
        {
          while (node2.next != null)
          {
            // Find where the number is within the index and add it to the total sum. The last node will be the highest number.
            sumNode.val = ((10 ^ index) * node2.val);
            index++;
            sumNode = sumNode.next;
          }
        }

        else if (node2.next == null)
        {
          while (node.next != null)
          {
            sumNode.val = ((10 ^ index) * node.val);
            index++;
            sumNode = sumNode.next;
          }
        }

        else
        {
          double localSum = node.val + node2.val;
          // If there is a carryOver value, add it to the local sum now.
          localSum += carryOver;

          // If any amount is greater than or equal to 10..
          if (localSum >= 10)
          {
            // round local sum
            localSum = Math.Floor(localSum / 10);
            // Make the carryover value the mod of 10.
            carryOver = Convert.ToInt32(localSum % 10);
          }

          sumNode.val = Convert.ToInt32(localSum);

          // Increment both linked lists and the index number
          node = node.next;
          node2 = node2.next;
          sumNode = sumNode.next;
          index++;
        }
      }

      // If there is a leftover caryover from the last value in linked list pair, account for it and add to sum
      if (carryOver != 0)
      {
            += ((10 ^ index + 1) * carryOver);
      }

      for(int i = 0; i < index; i++)
      {
      }

      }

      // init result list
      // init carryover value

        // while either is not null
        //    check l1 whether it is null
        //        if null the value to sum is "0"
        //        if not null grab the value and advance list ptr

        //    do the same for l2 as above for l1^
        //
        //    sum the l1 and l2 values and previous carryover
        //    store the "ones" value of the result in the "result" list
        //    store the carryover (and/or reset carryover to zero)
        //    advance the "result" list ptr
        //
        // return result


      // For the first index in in the list, multiply by 1,
      // Second in list multiply by 10
      // Third in list multiply by 100.
  }
}
