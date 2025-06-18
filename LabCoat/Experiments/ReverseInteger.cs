using System;
using System.Text;

namespace LabCoat.Experiments
{
    internal class ReverseInteger : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("Input: 123");
            Console.WriteLine("Expected Output: 321");
            Console.WriteLine("Output: " + ReverseTheInteger(123));
            
            Console.WriteLine("Input: -123");
            Console.WriteLine("Expected Output: -321");
            Console.WriteLine("Output: " + ReverseTheInteger(-123));

            Console.WriteLine("Input: 120");
            Console.WriteLine("Expected Output: 21");
            Console.WriteLine("Output: " + ReverseTheInteger(120));

            Console.WriteLine("Input: 120000");
            Console.WriteLine("Expected Output: 21");
            Console.WriteLine("Output: " + ReverseTheInteger(120000));
        }

        private int ReverseTheInteger(int num)
        {
            //psuedo code
            //take the number, convert it to a string
            //get rid of negative sign for now
            string numAsString = (num < 0 ) ? (num * -1).ToString(): num.ToString();
            //reverse the number,
            StringBuilder reversedNumString = new StringBuilder();
            bool isLeadingFlag = true;
            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                if (isLeadingFlag && numAsString[i] == '0') 
                { 
                    // Don't append leading zeroes
                } else
                {
                    isLeadingFlag = false;
                    reversedNumString.Append(numAsString[i]);
                }
            }
            //convert to int
            int reversedNum;
            //check if it's too big to be an int (return zero if so)
            bool isInRange = int.TryParse(reversedNumString.ToString(), out reversedNum);

            if (isInRange)
            {
            //add the negative sign if need be
                if (num < 0)
                {
                    reversedNum = reversedNum * -1;
                }
            //then return the reversed number with correct sign
            } else
            {
                reversedNum = 0;
            }
            return reversedNum;
        }

        public string IdentifyExperiment()
        {
            return "ReverseInteger";
        }
    }
}