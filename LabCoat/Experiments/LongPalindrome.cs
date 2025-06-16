using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class LongPalindrome : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("input: aracecarb");
            Console.WriteLine("expected output: racecar");
            Console.WriteLine(FindLongestPalindrome("aracecarb"));
            Console.WriteLine("input: aaabbbaac");
            Console.WriteLine("expected output: aabbbaa");
            Console.WriteLine(FindLongestPalindrome("aaabbbaac"));
            Console.WriteLine("input: asdfafddsfa");
            Console.WriteLine("expected output: dfafd");
            Console.WriteLine(FindLongestPalindrome("asdfafddsfa"));

            Console.WriteLine("input: asdfasdfsadfwerwerwerracecarwerwerwersdfsdfsdfsdf");
            Console.WriteLine("expected output: racecar");
            Console.WriteLine(FindLongestPalindrome("asdfasdfsadfwerwerwerracecarwerwerwersdfsdfsdfsdf"));
            
            Console.WriteLine("input: civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
            Console.WriteLine("expected output: racecar");
            Console.WriteLine(FindLongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"));

            Console.WriteLine("input: a");
            Console.WriteLine("expected output: a");
            Console.WriteLine(FindLongestPalindrome("a"));
            Console.WriteLine("input: ac");
            Console.WriteLine("expected output: a");
            Console.WriteLine(FindLongestPalindrome("ac"));
            Console.WriteLine("input: bb");
            Console.WriteLine("expected output: bb");
            Console.WriteLine(FindLongestPalindrome("bb"));
        }

        private string FindLongestPalindrome(string inputString)
        {
            if(inputString.Length == 1) { return inputString; }
            string result = "";
            List<string> listOfPalindromes = new List<string>();
            for (int i = 0; i < inputString.Length; i++) 
            {
                string firstLetter = inputString[i].ToString();
                listOfPalindromes.Add(firstLetter);
                string theRestOfTheString = inputString.Substring(i + 1);
                string stringToTest = firstLetter;
                foreach(var letter in theRestOfTheString)
                {
                    stringToTest += letter;
                    bool isPalindrome = IsStringToTestPalindrome(stringToTest);
                    if (isPalindrome) {
                        listOfPalindromes.Add(stringToTest);
                    }
                }
            }
            result = GetLongestString(listOfPalindromes);
            return result;
        }

        private bool IsStringToTestPalindrome(string stringToTest)
        {
            bool isPalindrome = true;

            //    Reverse the string
            string reversedString = "";

            for (int i = stringToTest.Length -1; i >= 0; i--)
            {
                reversedString += stringToTest[i].ToString();

                }
           // compare the reversed string to the incomingString

            for (int i =0; i < stringToTest.Length; i++)
            {
                if (stringToTest[i] == reversedString[i])
                {
                    // do nothing, isPalindrome is true by default
                }
                else
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }

        private string GetLongestString(List<string> listOfPalindromes)
        {
            string longest = "";
            int longestLengthSoFar = 0;
            foreach (var palindrome in listOfPalindromes)
            {
                if (palindrome.Length > longestLengthSoFar) { 
                  longest = palindrome.ToString();
                    longestLengthSoFar = palindrome.Length;
                }
            }
            return longest;
        }

        public string IdentifyExperiment()
        {
            return "LongPalindrome";
        }
    }
}

//inputString
//ListOfPalindromes
//for( int i = 0; i < string length; i++)
//{
//    for each letter, loop through the rest of the string and add each letter one by one
 
//    firstLetter = inputString[i];
//    theRestOfTheSTring = inputString.Substring(i + 1)
//   stringToTest
//   foreach (var character in theRestOfTheSTring)
//    {
//        stringToTest = firstLetter += character

//       IsStringToTestPalindrome(stringToTest)

//       if yes add to list
//   }
//}
//return ListOfPalindromes.GiveMeLongestString()

//IsStringToTestPalindrome(incomingString)
//{
//    isPalindrome = true

//    Reverse the string
//    reversedString

//    for (int i = incomingString.Length; i >= 0; i--)
//    {
//        reversedString += incomingString[i]

//    }
//    compare the reversed string to the incomingString

//    for (i i < length i++)
//    {
//        if (incomingString[i] == reversed[i])

//       else { isPalindrome = false}
//    }
//    return isPalindrome
//}