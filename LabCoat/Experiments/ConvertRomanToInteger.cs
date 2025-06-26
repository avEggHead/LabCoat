using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace LabCoat.Experiments
{
    internal class ConvertRomanToInteger : IExperiment
    {
        public void Experiment()
        {
            string input = "III";
            int expectedOutput = 3;
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Expected :" + expectedOutput);
            Console.WriteLine("Actual : " + RomanToInt(input));

            input = "LVIII";
            expectedOutput = 58;
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Expected :" + expectedOutput);
            Console.WriteLine("Actual : " + RomanToInt(input));

            input = "MCMXCIV";
            expectedOutput = 1994;
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Expected :" + expectedOutput);
            Console.WriteLine("Actual : " + RomanToInt(input));

            input = "XLVIII";
            expectedOutput = 48;
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Expected :" + expectedOutput);
            Console.WriteLine("Actual : " + RomanToInt(input));
        }
        //PsuedoCode
        //indexCounter
        //int finalInt
        //while (indexCounter<RomanNumeralString.Length)
        //{
        //	RomanNumeral = RomanNumeralString[indexCounter]
        //    int integerValue = int parse RomanNumeral
        //	is there a next number?
        //	if ! (indexCounter + 1 => RomanNumeralString.Length)
        //	NextRomanNumeral = RomanNumeralString[indexCounter + 1]
        //    int nextIntegerValue = int parse NextRomanNumeral

        //    If integerValue<nextIntegerValue

        //       integerValue = nextIntegerValue - integerValue
        //    finalInt = finalInt + integerValue

        //    indexCounter++
        //}
        public int RomanToInt(string s)
        {
            int finalInt = 0;
            int indexCounter = 0;
            string romanNumeral = "";
            int integerValue = 0;
            string nextRomanNumeral = "";
            int nextInteger = 0;
            while (indexCounter < s.Length)
            {
                romanNumeral = s[indexCounter].ToString();
                integerValue = ConvertToInteger(romanNumeral);

                if (!(indexCounter + 1 >= s.Length)) // if there is a next number
                {
                    nextRomanNumeral = s[indexCounter + 1].ToString();
                    nextInteger = ConvertToInteger(nextRomanNumeral);

                    if (integerValue < nextInteger)
                    {
                        integerValue = nextInteger - integerValue;
                        // you used the next digit so skip it
                        indexCounter++;
                    }
                }
                finalInt = finalInt + integerValue;
                indexCounter++;
            };   

            return finalInt;
        }

        public int ConvertToInteger(string romanNumeral)
        {
            Dictionary<string, int> romanNumeralIntegerValues = new Dictionary<string, int>()
            { {"I", 1 }, { "V", 5}, {"X", 10 }, {"L", 50 }, { "C",100},{"D",500  },{"M",1000 }};
            return romanNumeralIntegerValues.GetValueOrDefault(romanNumeral);
        }

        public string IdentifyExperiment()
        {
            return "ConvertRomanToInteger";
        }
    }
}