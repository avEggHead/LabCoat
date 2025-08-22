using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class EveryOtherSwap : IExperiment
    {
        public void Experiment()
        {
            List<int> numbers = new List<int>{ 1, 2, 3 };
            var orderedNumbers = this.OrderEveryOther(numbers);
            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
        }
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) {  return null; }
            ListNode result = new ListNode();

            List<int> values = new List<int>();
            ListNode next = head.next;
            values.Add(head.val);
            while (next != null)
            {
                values.Add(next.val);
                next = next.next; //
            }
            if (values.Count == 0) { return null; }


            List<int> orderedValues = this.OrderEveryOther(values);
            orderedValues.Reverse();
            ListNode lastOne = null;
            foreach (int orderedValue in orderedValues)
            {
                ListNode temp = new ListNode(orderedValue);
                temp.next = lastOne ?? null;
                result = temp;
                lastOne = temp;
            }

            return result;
        }

        private List<int> OrderEveryOther(List<int> values)
        {
            List<int> result = new List<int>();
            for (int index = 0; index < values.Count; index += 2)
            {
                int first = values[index];
                if (index + 1 < values.Count)
                {
                    int second = values[index+1];
                    result.Add(second);
                    result.Add(first);
                }
                else
                {
                    result.Add(first);
                }

            }
            return result;
        }

        public string IdentifyExperiment()
        {
            return "EveryOtherSwap";
        }
    }
}