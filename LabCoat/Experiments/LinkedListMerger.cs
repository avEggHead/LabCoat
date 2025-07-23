using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LinkedListMerger : IExperiment
    {
        public void Experiment()
        {
            throw new System.NotImplementedException();
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 == null && list2 == null) { return null; }
            ListNode mergeredList = new ListNode();
            List<int> values = new List<int>();
            // traverse list 1 extract values
            ListNode next = list1;
            while(next != null)
            {
                values.Add(next.val);
                next = next.next;
            }
            // traverse list 2 extract values
            next = list2;
            while (next != null)
            {
                values.Add(next.val);
                next = next.next;
            }
            values.Sort();
            values.Reverse();
            ListNode lastOne = null;
            foreach (int value in values)
            {
                ListNode temp = new ListNode(value);
                temp.next = lastOne ?? null;
                mergeredList = temp;
                lastOne = temp;
            }
            return mergeredList;
        }

        public string IdentifyExperiment()
        {
            return "LinkedListMerger";
        }
    }
}