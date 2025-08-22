using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class UpToPointListReverse : IExperiment
    {
        public void Experiment()
        {
            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var result = ReverseKGroup(node, 2);
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null) { return null; }
            ListNode result = new ListNode();

            List<int> values = new List<int>();
            ListNode next = head.next;
            values.Add(head.val);
            while (next != null)
            {
                values.Add(next.val);
                next = next.next; 
            }
            if (values.Count == 0) { return null; }

            List<int> reverseList = GenerateReverseList(values, k);
            List<int> remainderList = GenerateRemainderList(values, k);

            List<int> reverseFollowedByRemainderList = new List<int>();
            reverseFollowedByRemainderList.AddRange(reverseList);
            reverseFollowedByRemainderList.AddRange(remainderList);

            reverseFollowedByRemainderList.Reverse();
            ListNode lastOne = null;
            foreach (int orderedValue in reverseFollowedByRemainderList)
            {
                ListNode temp = new ListNode(orderedValue);
                temp.next = lastOne ?? null;
                result = temp;
                lastOne = temp;
            }

            return result;
        }

        private List<int> GenerateRemainderList(List<int> values, int k)
        {
            List<int> result = new List<int>();
            for (int i = k; i < values.Count; i++)
            {
                result.Add(values[i]);
            }
            return result;
        }

        private List<int> GenerateReverseList(List<int> values, int k)
        {
            List<int> reversedIntegers = new List<int>();
            for (int i = 0; i < k; i++)
            {
                reversedIntegers.Add(values[i]);
            }
            reversedIntegers.Reverse();

            return reversedIntegers;
        }

        public string IdentifyExperiment()
        {
            return "UpToPointListReverse";
        }
    }
}