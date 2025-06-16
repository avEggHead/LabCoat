using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LongestPalindromeRefactor : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("expected: a");
            Console.WriteLine(FindLongestPalindrome("a"));

            Console.WriteLine("expected: b");
            Console.WriteLine(FindLongestPalindrome("b"));

            Console.WriteLine("expected: aa");
            Console.WriteLine(FindLongestPalindrome("aa"));

            Console.WriteLine("expected: a");
            Console.WriteLine(FindLongestPalindrome("ab"));

            Console.WriteLine("expected: aaa");
            Console.WriteLine(FindLongestPalindrome("aaa"));

            Console.WriteLine("expected: aba");
            Console.WriteLine(FindLongestPalindrome("aba"));

            Console.WriteLine("expected: a");
            Console.WriteLine(FindLongestPalindrome("abc"));

            Console.WriteLine("expected: a");
            Console.WriteLine(FindLongestPalindrome("acda"));

            Console.WriteLine("expected: acca");
            Console.WriteLine(FindLongestPalindrome("acca"));

            Console.WriteLine("expected: aaaaa");
            Console.WriteLine(FindLongestPalindrome("aaaaa"));

            Console.WriteLine("expected: a");
            Console.WriteLine(FindLongestPalindrome("asdfa"));

            Console.WriteLine("expected: aaa");
            Console.WriteLine(FindLongestPalindrome("aaacd"));

            Console.WriteLine("expected: sss");
            Console.WriteLine(FindLongestPalindrome("fdsss"));

            Console.WriteLine("expected: dsssd");
            Console.WriteLine(FindLongestPalindrome("fdsssd"));

            Console.WriteLine("expected: racecar");
            Console.WriteLine(FindLongestPalindrome("asdfasdfasdfracecarasdfasdfasdfasdfasdoiuoiusdf"));

            Console.WriteLine("expected: racecar");
            Console.WriteLine(FindLongestPalindrome("rrrraracecarbrrrr"));

            Console.WriteLine("Long input");
            Console.WriteLine("expected: racecar");
            Console.WriteLine(FindLongestPalindrome("asdfasdfasdfwerwerwerwerwdfgdfgdfgdfgdfgasdfasdfasdfracecarasdfasdfasdfasdfasdoiuoiusdfwerwerwerwerwdoiuoiusdfwerwerwerwerwdoiuoiusdfwerwerwerwerwdoiuoiusdfwerwerwerwerwerwerwerwer"));

            Console.WriteLine("Long input cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc");
            Console.WriteLine("expected: cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc");
            Console.WriteLine(FindLongestPalindrome("cccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc"));

        }

        private string FindLongestPalindrome(string inputString)
        {
            List<Palindrome> palindromes = new List<Palindrome>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == 0) { palindromes.Add(new Palindrome(0,0,1)); }
                string potentialPal = "";
                int indexOfLeftChar = i - 1;
                int indexOfRightChar = i + 1;
                bool isCharLeft = (indexOfLeftChar < 0) ? false : true;
                bool isCharRight = (indexOfRightChar > inputString.Length - 1) ? false : true; 
                while (isCharLeft && isCharRight)
                {
                    bool isPal = (inputString[indexOfLeftChar] == inputString[indexOfRightChar]) ? true : false;

                    if (isPal)
                    {
                        Palindrome palindrome = new Palindrome(indexOfLeftChar, indexOfRightChar, (indexOfRightChar - indexOfLeftChar + 1) );
                        palindromes.Add(palindrome);
                        indexOfLeftChar--;
                        indexOfRightChar++;
                        isCharLeft = ((indexOfLeftChar) < 0) ? false : true;
                        isCharRight = ((indexOfRightChar) > inputString.Length - 1) ? false : true;
                    } else
                    {
                        break;
                    }
                }
                potentialPal = "";
                indexOfLeftChar = i;
                indexOfRightChar = i + 1;
                isCharLeft = true; 
                isCharRight = (i + 1 > inputString.Length -1)? false : true ;
                while (isCharLeft && isCharRight)
                {
                    bool isPal = (inputString[indexOfLeftChar] == inputString[indexOfRightChar]) ? true : false;

                    if (isPal)
                    {
                        Palindrome palindrome = new Palindrome(indexOfLeftChar, indexOfRightChar, (indexOfRightChar - indexOfLeftChar + 1));
                        palindromes.Add(palindrome);
                        indexOfLeftChar--;
                        indexOfRightChar++;
                        isCharLeft = ((indexOfLeftChar) < 0) ? false : true;
                        isCharRight = ((indexOfRightChar) > inputString.Length - 1) ? false : true;
                    } else
                    {
                        break;  
                    }
                }

            }
            Palindrome longest = palindromes.OrderByDescending(x => x.length).FirstOrDefault();
            string longestPal = inputString.Substring(longest.indexOfLeftChar, longest.length);
            return longestPal;
        }

        public string IdentifyExperiment()
        {
            return "LongestPalRefactor";
        }

        private class Palindrome
        {
            public int indexOfLeftChar;
            public int indexOfRightChar;
            public int length;

            public Palindrome(int indexOfLeftChar, int indexOfRightChar, int length)
            {
                this.indexOfLeftChar = indexOfLeftChar;
                this.indexOfRightChar = indexOfRightChar;
                this.length = length;
            }
        }
    }
}