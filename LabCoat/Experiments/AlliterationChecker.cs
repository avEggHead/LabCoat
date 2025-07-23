using System;
using System.Linq;
using System.Xml.Linq;

namespace LabCoat.Experiments
{
    internal class AlliterationChecker : IExperiment
    {
        public void Experiment()
        {
            string[] input = new string[] { "flower", "flow", "flight" };
            string output = "fl";
            Console.Write("input: ");
            foreach (string inputItem in input)
            {
                Console.Write(inputItem + " ");
            };
            Console.WriteLine();
            Console.WriteLine($"output: {output}");
            Console.WriteLine(LongestCommonPrefix(input));

            input = new string[] { "dog", "racecar", "car" };
            output = "";
            Console.Write("input: ");
            foreach (string inputItem in input)
            {
                Console.Write(inputItem + " ");
            };
            Console.WriteLine();
            Console.WriteLine($"output: {output}");
            Console.WriteLine(LongestCommonPrefix(input));

            input = new string[] { "fancy", "fancyasdfasldkjwer", "fancyerererwweweraaa" };
            output = "fancy";
            Console.Write("input: ");
            foreach (string inputItem in input)
            {
                Console.Write(inputItem + " ");
            };
            Console.WriteLine();
            Console.WriteLine($"output: {output}");
            Console.WriteLine(LongestCommonPrefix(input));
        }
        //        index = 0;
        //alliterationPattern = "";
        //isDone = false;
        //foreach element in the string array
        //  if (isDone) break;
        //  characterToCompare = element[index]
        //  stringCheckerIndex = 0
        //  foreach element in string array
        //        {
        //      if (element[stringBuilderIndex] == characterToCompare)
        //	  {
        //		alliterationPattern = alliterationPattern + characterToCompare.ToString()
        //        stringCheckerIndex++
        //      } else
        //	  // force break of both loops
        //	  isDone = true;
        //	  break;
        //	  
        //return alliterationPattern
        public string LongestCommonPrefix(string[] strs)
        {
            string alliterationPattern = "";
            int index = 0;
            bool isDone = false;
            char characterToCompare = default;
            string shortestString = GetShortestString(strs);
            int countOfStrs = strs.Length;
            for (int i = 0; i <= shortestString.Length; i++)
            {
                if (isDone) break;
                string substring = shortestString.Substring(0, i);
                int counter = 0;
                foreach (var word in strs)
                {
                    counter++;
                    if (substring != word.Substring(0, i))
                    {
                        isDone = true;
                        break;
                    } else
                    {
                        if(counter == countOfStrs)
                        {
                            alliterationPattern = substring; 
                        }
                    }
                }
            }
            return alliterationPattern;
        }

        private string GetShortestString(string[] strs)
        {
            return strs.OrderBy(x => x.Length).First();
        }

        public string IdentifyExperiment()
        {
            return "AlliterationChecker";
        }
    }
}