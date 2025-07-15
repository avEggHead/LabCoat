using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LinkedListNodeRemover : IExperiment
    {
        public void Experiment()
        {
            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            RemoveNthFromEnd(node, 2);

            ListNode newNode = new ListNode(1);
            var result = RemoveNthFromEnd(newNode, 1);

            Console.WriteLine("done");
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Console.WriteLine("Count the old list");
            Console.WriteLine("Head val: " + head.val);
            ListNode next = head;
            int counter = 0;
            List<int> values = new List<int>();

            while (next != null)
            {
                Console.WriteLine(next.val);
                values.Add(next.val);
                next = next.next;
                counter++;
            }

            values.RemoveAt(counter - n);
            values.Reverse();
            ListNode newNode = null;
            ListNode lastOne = null;
            int index = 0;
            foreach (int value in values)
            {
                ListNode temp = new ListNode(value);
                temp.next = lastOne ?? null;
                newNode = temp;
                lastOne = temp;
            }
            
            return newNode;
        }

        public string IdentifyExperiment()
        {
            return "LinkedListNodeRemover";
        }
    }
}