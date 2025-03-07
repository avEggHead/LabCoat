using System;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class TwoSum : IExperiment
    {
        public void Experiment()
        {
            int[] nums = new int[] {3,2,3};
            int target = 6;
            var result = MakeTwoSum(nums, target);

            Console.WriteLine(result[0] + " " + result[1]);
        }

        private int[] MakeTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        public string IdentifyExperiment()
        {
            return "TwoSum";
        }
    }
}