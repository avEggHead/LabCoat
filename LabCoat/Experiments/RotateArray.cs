using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class RotateArray : IExperiment
    {
        public void Experiment()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 30000000;

            nums = Rotate(nums, k);

            Console.WriteLine(string.Join(", ", nums));
        }

        private int[] Rotate(int[] nums, int k)
        {
            // convert array to list
            List<int> numbers = new List<int>(nums);
            int[] result = new int[nums.Length];

            for (Int64 i = 0; i < k; i++)
            {
                int numberAtEnd = numbers.Last();
                numbers.Remove(numberAtEnd);
                numbers.Insert(0, numberAtEnd);
            }
            result = numbers.ToArray();
            return result;
            //suggested optimized solution
            //k = k % nums.Length; // In case k is larger than the array size
            //int[] result = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int newIndex = (i + k) % nums.Length;
            //    result[newIndex] = nums[i];
            //}

            //return result;
        }

        public string IdentifyExperiment()
        {
            return "RotateArray";
        }
    }
}