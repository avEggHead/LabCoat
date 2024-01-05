using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class MaxSubArraySum : IExperiment
    {
        public void Experiment()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = this.MaxSubArray(nums);
            Console.WriteLine($"Maximum subarray sum is: {result}");
        }

        private int MaxSubArray(int[] nums)
        {
            int counter = 0;
            List<List<int>> list = new List<List<int>>();
            List<int> maxArray = new List<int>();
            foreach(int num in nums)
            {
                List<int> contiguousInts = new List<int>();
                for(int i = counter; i < nums.Length; i++)
                {
                    contiguousInts.Add(nums[i]);
                }
                
                counter++;
                list.Add(contiguousInts);
            }
            foreach(var subArray in list)
            {
                if(subArray.Sum() > maxArray.Sum())
                {
                    maxArray = new List<int>(subArray);
                }
            }
            return maxArray.Sum();
        }

        public string IdentifyExperiment()
        {
            return nameof(MaxSubArraySum);
        }
    }
}