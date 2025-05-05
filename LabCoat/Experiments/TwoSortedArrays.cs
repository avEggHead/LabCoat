using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class TwoSortedArrays : IExperiment
    {
        public void Experiment()
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 4 };
            // merge the arrays into one

            List<int> nums1List = nums1.ToList();
            List<int> nums2List = nums2.ToList();
            List<int> both = new List<int>();
            both.AddRange(nums1List);
            both.AddRange(nums2List);

            double median = 0;
            // sort ascending
            var ordered = both.OrderBy(x => x).ToArray();
            // if odd take middle number
            // if even find the two middle numbers and average them
            if (ordered.Count() % 2 == 0) 
            { 
                int index1 = ordered.Count() / 2 - 1;
                int index2 = ordered.Count() / 2;
                median = (ordered[index1] + ordered[index2]) / 2d;
            } 
            else
            {
                median = ordered[ordered.Count() / 2];
            }
            Console.WriteLine(median);
        }

        public string IdentifyExperiment()
        {
            return "TwoSortedArrays";
        }
    }
}