using System;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class FindMissingNumber : IExperiment
    {
        public void Experiment()
        {
            //int[] nums = { 3, 7, 1, 2, 8, 4, 5 }; //expected 6
            //int[] nums = { 0, 1, 2, 4, 5, 6, 7, 8, 9 }; // expected 3
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // expected 0
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 9 }; // expected 8
            int missingNumber = FindTheMissingNumber(nums);
            Console.WriteLine($"Missing number is: {missingNumber}");
        }

        private int FindTheMissingNumber(int[] nums)
        {
            int result = 0;

            //find the max in the array
            int max = 0;
            foreach(int num in nums)
            {
                if(num > max)
                {
                    max = num;
                }
            }

            // sum from 0 to max
            int sumFrom0toMax = 0;
            for(int i = 0; i <= max; i++)
            {
                sumFrom0toMax = sumFrom0toMax + i;
            }

            // sum the nums array
            int sumOfNums = 0;
            foreach(int num in nums)
            {
                sumOfNums = sumOfNums + num;
            }
            // subtract sum of nums from sum from 0 to max.  That's the missing number.
            result = sumFrom0toMax - sumOfNums;

            return result;
        }

        public string IdentifyExperiment()
        {
            return nameof(FindMissingNumber);
        }
    }
}