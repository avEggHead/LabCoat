using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class RemoveDuplicatesFromArray : IExperiment
    {
        public void Experiment()
        {
            int[] ints = { 1,1,2};
            RemoveDuplicates(ints);
            var after = "";
        }

        public int RemoveDuplicates(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int i in nums)
            {
                set.Add(i);
            } 

            int[] newNums = new int[set.Count];

            int index = 0;

            foreach(int number in set)
            {
                nums[index] = number;
                index++;
            }

            return set.Count;  
        }

        public string IdentifyExperiment()
        {
            return "RemoveDuplicatesFromArray";
        }
    }
}