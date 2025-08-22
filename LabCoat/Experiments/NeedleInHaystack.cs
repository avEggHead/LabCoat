using System;

namespace LabCoat.Experiments
{
    internal class NeedleInHaystack : IExperiment
    {
        public void Experiment()
        {
            int result = this.StrStr("hello", "ll");
            Console.WriteLine("Expected: 2");
            Console.WriteLine("Actual: " + result);

            int result2 = this.StrStr("sadbutsad", "sad");
            Console.WriteLine("Expected: 0");
            Console.WriteLine("Actual: " + result2);
        }
        public int StrStr(string haystack, string needle)
        {
            int result = 0;
            if (!haystack.Contains(needle))
            {
                result = -1;
            }
            else
            {
                result = FindFirstIndexOfMatch(haystack, needle);
            }

            return result;
        }

        private int FindFirstIndexOfMatch(string haystack, string needle)
        {
            int indexOfNeedle = 0;
            
            for(int indexOfHaystack = 0; indexOfHaystack < haystack.Length; indexOfHaystack++)
            {
                int tempHaystackIndex = indexOfHaystack;
                int tempNeedleIndex = 0;
                bool isFound = false;
                while (haystack[tempHaystackIndex] == needle[tempNeedleIndex])
                {
                    if(tempNeedleIndex == needle.Length - 1)
                    {
                        indexOfNeedle = indexOfHaystack;
                        isFound = true;
                        break;
                    }
                    else
                    {
                        tempNeedleIndex++;
                        tempHaystackIndex++;
                    }
                };
                if (isFound) break;
            }

            return indexOfNeedle;
        }

        public string IdentifyExperiment()
        {
            return "NeedleInHaystack";
        }
    }
}