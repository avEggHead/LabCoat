using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class FindIndex : IExperiment
    {
        public void Experiment()
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            int expectedIndex = 2;
            Console.WriteLine($"Expected Index: {expectedIndex}");
            Console.WriteLine($"  Actual Index: {SearchInsert(nums,target)}");

            int[] nums1 = { 1, 3, 5, 6 };
            int target1 = 2;
            int expectedIndex1 = 1;
            Console.WriteLine($"Expected Index: {expectedIndex1}");
            Console.WriteLine($"  Actual Index: {SearchInsert(nums1, target1)}");
        }

        public int SearchInsert(int[] nums, int target)
        {
            HashSet<int> numsHashSet = new HashSet<int>();
            foreach (int i in nums)
            {
                numsHashSet.Add(i);
            }
            numsHashSet.Add(target);
            var orderedNums = numsHashSet.OrderBy(i => i).ToList();
            var result = orderedNums.IndexOf(target);
            return result;
        }

        public string IdentifyExperiment()
        {
            return "FindIndex";
        }
    }
}