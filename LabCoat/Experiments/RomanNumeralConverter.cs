using System;

namespace LabCoat.Experiments
{
    internal class RomanNumeralConverter : IExperiment
    {
        public void Experiment()
        {
            int input = 3749;
            string output = "MMMDCCXLIX";
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected: {output}");
            Console.WriteLine($"Actual:   {intToRoman(input)}");

            input = 5;
            output = "V";
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected: {output}");
            Console.WriteLine($"Actual:   {intToRoman(input)}");
        }


        //int moduloFactor = 10;
        //While(number > 0)
        //{
        //    PlaceNumber = number % moduloFactor;
        //    RomanNumeral.Append(ConvertToRomanNumeral(PlaceNumber, moduloFactor)
        
        //    moduloFactor = moduloFactor * 10;
        //}

        string intToRoman(int num)
        {
            string romanNumeral = "";
            string ones = "";
            string tens = "";
            string hundreds = "";
            string thousands = "";

            int moduloFactor = 10;
            int placeNumber = 0;
            while (num > 0) 
            {
                placeNumber = num % moduloFactor;
                switch (moduloFactor)
                {
                    case 10:
                        ones = ConvertToOnes(placeNumber);
                        break;
                    case 100:
                        tens = ConvertToTens(placeNumber);
                        break;
                    case 1000:
                        hundreds = ConvertToHundreds(placeNumber);
                        break;
                    case 10000:
                        thousands = ConvertToThousands(placeNumber);
                        break;
                }
                moduloFactor = moduloFactor * 10;
                num = num - placeNumber;
            }
            romanNumeral = thousands + hundreds + tens + ones;
            return romanNumeral;
        }

        private string ConvertToThousands(int placeNumber)
        {
            string result = "";
            for (int i = 0; i < placeNumber / 1000; i++)
            {
                result += "M";
            }
            return result;
        }

        private string ConvertToHundreds(int placeNumber)
        {
            string result = "";
            if (placeNumber == 400) { result = "CD"; }
            else if (placeNumber == 900) { result = "CM"; }
            else
            {
                if (placeNumber < 500)
                {
                    for (int i = 0; i < placeNumber/100; i++)
                    {
                        result += "C";
                    }
                }
                else if (placeNumber >= 500)
                {
                    for (int i = 0; i < (placeNumber - 500) / 100; i++)
                    {
                        result += "C";
                    }
                    result = "D" + result;
                }
            }
            return result;
        }

        private string ConvertToTens(int placeNumber)
        {
            string result = "";
            if (placeNumber == 40) { result = "XL"; }
            else if (placeNumber == 90) { result = "XC"; }
            else
            {
                if (placeNumber < 50) 
                {
                    for (int i = 0; i < placeNumber / 10; i++)
                    {
                        result += "X";
                    }
                }
                else if (placeNumber >= 50)
                {
                    for (int i = 0; i < (placeNumber - 50) / 10; i++)
                    {
                        result += "X";
                    }
                    result = "L" + result;
                }
            }
            return result;
        }

        private string ConvertToOnes(int placeNumber)
        {
            string result = "";
            if (placeNumber == 4) { result = "IV"; }
            else if (placeNumber == 9) { result = "IX"; }
            else
            {
                if (placeNumber < 5)
                {
                    for (int i = 0; i < placeNumber; i++) 
                    {
                        result += "I";
                    }
                }
                else if (placeNumber >= 5)
                {
                    for (int i = 0; i < placeNumber - 5; i++)
                    {
                        result += "I";
                    }
                    result = "V" + result;
                }
            }
            return result;
        }

        public string IdentifyExperiment()
        {
            return "RomanNumeralConverter";
        }
    }
}