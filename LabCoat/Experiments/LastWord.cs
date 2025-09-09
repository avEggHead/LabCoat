using System;

namespace LabCoat.Experiments
{
    internal class LastWord : IExperiment
    {
        public void Experiment()
        {
            string s1 = "Hello World";
            int expected1 = 5;
            int actual1 = LengthOfLastWord(s1);
            Console.WriteLine($"Expected: {expected1}");
            Console.WriteLine($"  Actual: {actual1}");

            string s2 = "   fly me   to   the moon  ";
            int expected2 = 4;
            int actual2 = LengthOfLastWord(s2);
            Console.WriteLine($"Expected: {expected2}");
            Console.WriteLine($"  Actual: {actual2}");

            string s3 = "luffy is still joyboy";
            int expected3 = 6;
            int actual3 = LengthOfLastWord(s3);
            Console.WriteLine($"Expected: {expected3}");
            Console.WriteLine($"  Actual: {actual3}");
        }
        public int LengthOfLastWord(string s)
        {
            var sWithoutTrailingSpaces = s.Trim();
            // find the index of the last space
            int indexOfLastSpace = s.Trim().LastIndexOf(' ');

            // perform a math operation to get the length
            int length = s.Trim().Length - (s.Trim().LastIndexOf(' ') + 1);

            return length;
        }

        public string IdentifyExperiment()
        {
            return "LengthOfLastWord";
        }
    }
}