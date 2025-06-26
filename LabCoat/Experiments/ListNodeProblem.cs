using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LabCoat.Experiments
{
    internal class Problem : IExperiment
    {
        public void Experiment()
        {
            //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            //ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            //ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9)));

            ListNode l1 = new ListNode(9);
            ListNode l2 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))))));
            var result = AddTwoNumbers(l1 , l2);
            Console.WriteLine(  "hi");

        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // extract the number from L1
            BigInteger extractedNumberL1 = ExtractNumberFromListNode(l1);
            // extract the number from L2
            BigInteger extractedNumberL2 = ExtractNumberFromListNode(l2);
            // add them together
            BigInteger sum = extractedNumberL1 + extractedNumberL2;

            // build a ListNode from the result of adding them
            ListNode result = BuildListNodeFromNumber(sum);

            // return the ListNode
            return result;
        }

        private ListNode BuildListNodeFromNumber(BigInteger sum)
        {
            string numberAsString = sum.ToString();
            ListNode node = null;
            ListNode previousNode = null;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                var number = int.Parse(numberAsString[i].ToString());
                node = new ListNode(number, previousNode);
                previousNode = node;
            }

            return node;
        }

        private BigInteger ExtractNumberFromListNode(ListNode l1)
        {
            var node = l1;
            string final = "";
            while (node != null)
            {
                final = node.val.ToString() + final;
                node = node.next;
            }

            return BigInteger.Parse(final);
        }

        public string IdentifyExperiment()
        {
            return "ListNodeProblem";
        }
    }


      public class ListNode {
          public int val;
          public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
              this.val = val;
            this.next = next;
         }
      }
 



}