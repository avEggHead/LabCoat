using System;

namespace LabCoat.Experiments
{
    internal class FirstUniqueChar : IExperiment
    {
        public void Experiment()
        {
            //string input = "loveleetcode";
            string input = "leetcode";
            int result = this.FirstUniqChar(input);
            Console.WriteLine($"The index of the first non-repeating character is: {result}");
        }

        private int FirstUniqChar(string input)
        {
            // loop through all the chars.  Compare it with all the other chars.  If it matches any, move to the next. 
            // if it doesn't match.  That's the one.
            int result = 0;
            for(int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                for(int j = i; j < input.Length; j++)
                {
                    if (j + 1 < input.Length)
                    {
                        char nextChar = input[j + 1];
                        if (c == nextChar)
                        {
                            break;
                        }
                        else if (j+2 == input.Length)
                        {
                            result = i;
                            return result;
                        }
                    }
                }
            }
            return result;
        }

        public string IdentifyExperiment()
        {
            return nameof(FirstUniqueChar);
        }
    }
}