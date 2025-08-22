using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class RemoveOccurencesOfInteger : IExperiment
    {
        public void Experiment()
        {
            throw new System.NotImplementedException();
        }
        public int RemoveElement(int[] nums, int val)
        {
            List<int> numbers = new List<int>();

            foreach (int number in nums)
            {
                if(number != val) numbers.Add(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                nums[i] = numbers[i];
            }

            return numbers.Count;
        }

        public string IdentifyExperiment()
        {
            return "RemoveOccurencesOfInteger";
        }
    }
}