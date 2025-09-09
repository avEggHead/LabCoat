using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Reflection.Metadata;
using System;

namespace LabCoat.Experiments
{
    internal class NearestSetOfThreeSumToTarget : IExperiment
    {
        public void Experiment()
        {
            int[] input = { 5, 4, 3, 6, 4, 7, 2, };
            int target = 9;
            int output = 10;

            Console.WriteLine($"input: 5, 4, 3, 6, 4, 7, 2");
            Console.WriteLine($"expected {output}");
            Console.WriteLine($"actual {ThreeSumClosest(input, target)}");

            input = new int[] {0,0,0 };
            target =1;
            output = 0;

            Console.WriteLine($"input: 5, 4, 3, 6, 4, 7, 2");
            Console.WriteLine($"expected {output}");
            Console.WriteLine($"actual {ThreeSumClosest(input, target)}");



            input = new int[] { -1, 2, 1, -4 };
            target = 1;
            output = 2;

            Console.WriteLine($"input: 5, 4, 3, 6, 4, 7, 2");
            Console.WriteLine($"expected {output}");
            Console.WriteLine($"actual {ThreeSumClosest(input, target)}");

            input = new int[] { 1, 1, 1, 0 };
            target = -100;
            output = 2;

            Console.WriteLine($"input: 5, 4, 3, 6, 4, 7, 2");
            Console.WriteLine($"expected {output}");
            Console.WriteLine($"actual {ThreeSumClosest(input, target)}");
        }


        //Test cases:
        //input output
        //5 4 3 6 4 7 2  |  9     5 3 2       10
        //3 1 0 0 5 4 8  |  13    8 4 1       13
        //-1 2 1 -4      |  1     -1 2 1       2 
        //How to Solve
        //Produce all possible sets of three
        //Loop through those
        //Keep track of the nearest sum to target
        //(this is an absolute value of the target - the sum)
        //once you've gone through the list you know the set with the nearest Sum
        //Return nearest Sum
        public int ThreeSumClosest(int[] nums, int target)
        {
            int nearestSum = int.MaxValue;
            int nearestDistance = int.MaxValue;
            bool isTargetNegative = (target < 0) ? true : false;

            for(int i =0; i < nums.Length - 2; i++)
            {
                var intOne = nums[i];
                var intTwo = 0;
                var intThree = 0;
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (j == i) continue;
                    intTwo = nums[j];
                    for(int h = j + 1; h < nums.Length; h++)
                    {
                        if (h == i || h == j) continue;
                        intThree = nums[h];
                        Console.WriteLine(intOne + " " + intTwo + " " + intThree);
                        // there has to be different handling for  negative versus positive target
                        bool isSumNegative = ((intOne + intTwo + intThree) < 0) ? true : false;
                        bool isThisSumCloser = false;
                        int sum = (intOne + intTwo + intThree);
                        if (!isTargetNegative && isSumNegative)
                        {
                            int distance = target + Math.Abs(sum);
                            isThisSumCloser = distance < nearestDistance? true: false ;
                            if (isThisSumCloser) nearestDistance = distance;
                        } else if (!isTargetNegative && !isSumNegative)
                        {
                            int distance = Math.Abs(target - sum);
                            isThisSumCloser = distance < nearestDistance ? true: false ;
                            if (isThisSumCloser) nearestDistance = distance;
                        }
                        else if (isTargetNegative && !isSumNegative)
                        {
                            int distance = Math.Abs(target) + sum;
                            isThisSumCloser = distance < nearestDistance ? true: false ;
                            if (isThisSumCloser) nearestDistance = distance;
                        }
                        else if (isTargetNegative && isSumNegative)
                        {
                            int distance = Math.Abs(Math.Abs(target) - Math.Abs(sum));
                            isThisSumCloser = distance < nearestDistance ? true: false ;
                            if (isThisSumCloser) nearestDistance = distance;
                        }

                        nearestSum = (isThisSumCloser) ? sum : nearestSum;
                    }
                }
            }

            return nearestSum;
        }

        public string IdentifyExperiment()
        {
            return "NearestSetOfThreeSumToTarget";
        }
    }
}