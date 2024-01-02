using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LongestConsecutiveElements : IExperiment
    {
        public void Experiment()
        {
            //int[] nums = { 100, 4, 200, 1, 3, 2 };
            //int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
            int[] nums = { 10, 5, 12, 3, 55, 30, 4, 11, 2 };
            int length = this.LongestConsecutive(nums);
            Console.WriteLine($"The length of the longest consecutive sequence is: {length}");
        }

        private int LongestConsecutive(int[] nums)
        {
            HashSet<int> uniqueNumsInOrder = new HashSet<int>();
            foreach(int num in nums)
            {
                uniqueNumsInOrder.Add(num);
            }
            var orderedNums = uniqueNumsInOrder.OrderBy(x => x).ToArray();
            int count = 0;
            int maxLength = 0;
            for(int i=0; i < orderedNums.Length; i++)
            {

                if (i == 0) { count++; continue; }
                if (orderedNums[i] == orderedNums[i-1] + 1)
                {
                    count++;
                    if (i == orderedNums.Length - 1)
                    {
                        maxLength = count;
                    }
                }
                else
                {
                    if(maxLength < count) maxLength = count;
                    count = 1;
                }
            }
            return maxLength;
        }

        public string IdentifyExperiment()
        {
            return nameof(LongestConsecutiveElements);
        }
    }
}