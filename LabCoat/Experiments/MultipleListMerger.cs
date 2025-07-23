using System.Collections;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class MultipleListMerger : IExperiment
    {
        public void Experiment()
        {
            throw new System.NotImplementedException();
        }


        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = new ListNode();
            List<int> values = new List<int>();

            foreach (ListNode l in lists)
            {
                ListNode next = l;
                while (next != null)
                {
                    values.Add(next.val);
                    next = next.next;
                }
            }
            if (values.Count == 0) { return null; }
            values.Sort();
            values.Reverse();
            ListNode lastOne = null;
            foreach (int value in values)
            {
                ListNode temp = new ListNode(value);
                temp.next = lastOne ?? null;
                result = temp;
                lastOne = temp;
            }

            return result;
        }

        public string IdentifyExperiment()
        {
            return "MultipleListMerger";
        }
    }
}