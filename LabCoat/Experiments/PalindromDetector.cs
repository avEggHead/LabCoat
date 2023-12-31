using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class PalindromeDetector : IExperiment
    {
        public void Experiment()
        {
            //string input = "A man, a plan, a canal, Panama";
            string input = "A Santa at NASA";
            bool result = this.IsPalindrome(input);
            Console.WriteLine($"Is palindrome: {result}");
        }
        
        public bool IsPalindrome(string s)
        {
            // Your code here
            bool result = false;
            List<char> charsToRemove = new List<char>() { ' ', ',', '\'', ':', ';' };
            string formattedText = new string(s.Where(c => !charsToRemove.Contains(c)).ToArray()).ToLower();
            string formattedTextInReverse = new string(formattedText.Reverse().ToArray());  

            result = formattedTextInReverse.Equals(formattedText);

            return result; ;
        }

        public string IdentifyExperiment()
        {
            return "PalindromDetector";
        }
    }
}