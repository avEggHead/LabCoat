using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class IsWeirdStringValid : IExperiment
    {
        public void Experiment()
        {
            //string input = "()[{}]";
            //string input = "[({})({}[])]";
            //string input = "";
            //string input = "(([[{{}}]]))";
            string input = "{[}]";
            bool result = this.IsValid(input);
            Console.WriteLine($"Is valid: {result}");
        }

        private bool IsValid(string input)
        {
            bool isValid = false;
            // create a list of chars from the input
            List<char> inputString = new List<char>();
            foreach(var c in input)
            {
                inputString.Add(c);
            }
            List<char> workingCharSet = new List<char>(inputString);
            foreach(var bracket in inputString)
            {
                try
                {
                    if(bracket == ']' || bracket == '}' || bracket == ')')
                    {
                        int lastIndexOfOpen = 0;
                        int lastIndexOfClose = 0;
                        if (bracket == ']')
                        {
                            lastIndexOfOpen = workingCharSet.LastIndexOf('[');
                            lastIndexOfClose = workingCharSet.LastIndexOf(']');
                        }
                        if (bracket == '}')
                        {
                            lastIndexOfOpen = workingCharSet.LastIndexOf('{');
                            lastIndexOfClose = workingCharSet.LastIndexOf('}');
                        }
                        if (bracket == ')')
                        {
                            lastIndexOfOpen = workingCharSet.LastIndexOf('(');
                            lastIndexOfClose = workingCharSet.LastIndexOf(')');
                        }
                        workingCharSet.RemoveAt(lastIndexOfClose);
                        workingCharSet.RemoveAt(lastIndexOfOpen);
                    }
                }
                catch
                {
                    break;
                }
            }
            if (workingCharSet.Count == 0) isValid = true;

            return isValid;
        }

        public string IdentifyExperiment()
        {
            return nameof(IsWeirdStringValid);
        }
    }
}