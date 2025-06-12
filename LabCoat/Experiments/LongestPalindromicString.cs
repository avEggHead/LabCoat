using System;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LongestPalindromicString : IExperiment
    {
        public void Experiment()
        {
            int endIndex = 1;
            int startIndex = 0;
            string longestSoFar = "";
            string input = "asfasdwereeeeersnn";
            // advance the end index
            while (endIndex < input.Length)
            {
                // get substring
                string substring = input.Substring(startIndex, endIndex - startIndex);
                // temp reverse string
                string tempReverseString = ReverseTheOrder(substring);
                // check to see if it's the same forwards and backwards
                int counter = 0;
                bool isPalindrome=false;
                foreach (char c in substring) {
                    if (c == tempReverseString[counter])
                    {   
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    isPalindrome = true;
                }
                if (isPalindrome)
                {
                    // If it is check it against
                    // longestSoFar and advance the endIndex
                    endIndex++;
                    if (substring.Length > longestSoFar.Length)
                    {
                        Console.WriteLine("I'm the new longest " + substring);
                        longestSoFar = substring;
                    }
                }
                else
                {
                    // if it isn't advance the startIndex
                    startIndex++;
                }
                
            }
            Console.WriteLine(longestSoFar);
        }

        private string ReverseTheOrder(string input)
        {
            string result;
            char[] chars = new char[input.Length];
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--) {
                chars[counter] = input[i];
                counter++;
            }
            result = new string(chars);
            return result;
        }

        public string IdentifyExperiment()
        {
            return "LongestPalindromicString";
        }
    }
}