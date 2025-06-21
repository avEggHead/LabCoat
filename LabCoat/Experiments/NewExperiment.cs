using System;
using System.Text;

namespace LabCoat.Experiments
{
    internal class NewExperiment : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine($"Input: 123456 Expected: false  Actural: {IsPalindrome(123456)}");
            Console.WriteLine($"Input: 122221 Expected: true  Actural: {IsPalindrome(122221)}");
            Console.WriteLine($"Input: 1 Expected: true  Actural: {IsPalindrome(1)}");
            Console.WriteLine($"Input: 11 Expected: true  Actural: {IsPalindrome(11)}");
            Console.WriteLine($"Input: 000 Expected: true  Actural: {IsPalindrome(000)}");
            Console.WriteLine($"Input: -121 Expected: false  Actural: {IsPalindrome(-121)}");
        }

        public bool IsPalindrome(int x)
        {
        //        Steps:
        //            if there was a -sign return false immediately.
        //Take the integer and convert it to a string.
        //reverse the string store in new variable
        //compare reversed string to regular string char by char
        //if the reversed string matches the regular string
        //return true otherwise return false

        //if (x < 0) { return false; }
        //            result;
        //            string xAsString = x.ToString()
        //string xReversed = ReverseString(xAsString)
        //bool isPal = Compare(xAsString, xReversed)
        //if isPal return true else return false

            if (x < 0) { return false; }
            bool isPal = false;
            string xString = x.ToString();
            string xReversed = ReverseString(xString);
            isPal = string.Equals(xString, xReversed);

            return isPal;
        }

        private string ReverseString(string xString)
        {
            StringBuilder result = new StringBuilder();

            for (int i = xString.Length - 1; i >= 0; i--) 
            {
                result.Append( xString[i] );
            }

            return result.ToString();
        }

        public string IdentifyExperiment()
        {
            return "New Experiment";
        }
    }
}