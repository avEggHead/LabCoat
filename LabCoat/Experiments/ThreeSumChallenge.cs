using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class ThreeSumChallenge : IExperiment
    {
        public void Experiment()
        {
            int[] input = { -1, 0, 1, 2, -1, -4, -1, 0, 1 };
            var result = ThreeSum(input);

            foreach (var item in result) 
            {
                foreach(var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            };

             input = new int[] { -2, 0, 1, 1, 2 };
             result = ThreeSum(input);

            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            };
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<List<int>> HashSetofIntegerArrays = new List<List<int>>();
            int firstNum;
            int secondNum;
            int thirdNum;
            for (int i = 0; i < nums.Length; i++)
            {
                firstNum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j + 1 == nums.Length) break;
                    secondNum = nums[j];
                    thirdNum = nums[j + 1];

                    if (firstNum + secondNum + thirdNum == 0 )
                    {
                        int[] numSet = { firstNum, secondNum, thirdNum };
                        bool alreadyExists = CheckForDuplicate(numSet, HashSetofIntegerArrays);

                        if (alreadyExists)
                        {
                            // do nothing
                        }
                        else
                        {
                            HashSetofIntegerArrays.Add(numSet.ToList());
                        }
                    }
                }
            }

            foreach(var set in HashSetofIntegerArrays)
            {
                result.Add(set);
            }

            return result;
        }

        private bool CheckForDuplicate(int[] numSet, List<List<int>> aBunchOfIntegerLists)
        {
            var isMatch = false;

            foreach(var set in aBunchOfIntegerLists)
            {
                int number1 = set[0];
                int number2 = set[1];
                int number3 = set[2];
                bool number1Used = false;
                bool number2Used = false;
                bool number3Used = false;
                if (isMatch) { break; }
                foreach(var num in numSet)
                {
                    if (number1 == num && !number1Used)
                    {
                        number1Used = true;
                    }
                    else if (number2 == num && !number2Used)
                    {
                        number2Used = true;
                    }
                    else if (number3 == num && !number3Used)
                    {
                        number3Used = true;
                    }
                    if (number1Used && number2Used && number3Used) 
                    { 
                        isMatch = true;
                        break;
                    }
                }

            }
            return isMatch;
        }

        public string IdentifyExperiment()
        {
            return "3SumChallenge";
        }
    }
}