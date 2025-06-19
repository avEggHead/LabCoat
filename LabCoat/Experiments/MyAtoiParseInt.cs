using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LabCoat.Experiments
{
    internal class MyAtoiParseInt : IExperiment
    {
        public void Experiment()
        {
            //test cases
            //"42" 42
            //"-042" 42
            //"asdfasdf" 0
            //"      " 0
            //"      -" 0
            //"1334c0d3" 1337
            //"0-1" 0
            //"50000000000000" Int.Max
            //"-500000000000000" Int.Min
            Console.WriteLine("\"42\" 42");
            Console.WriteLine(MyAtoi("42"));

            Console.WriteLine("\"-042\" -42");
            Console.WriteLine(MyAtoi("-042"));

            Console.WriteLine("\"asdfasdf\" 0");
            Console.WriteLine(MyAtoi("asdfasdf"));

            Console.WriteLine("\"      \" 0");
            Console.WriteLine(MyAtoi("        "));
            Console.WriteLine("\"      -\" 0");
            Console.WriteLine(MyAtoi("       -"));
            Console.WriteLine("\"1334c0d3\" 1334");
            Console.WriteLine(MyAtoi("1334c0d3"));

            Console.WriteLine("\"0-1\" 0");
            Console.WriteLine(MyAtoi("0-1"));
            Console.WriteLine("\"50000000000000\"" + " " + int.MaxValue);
            Console.WriteLine(MyAtoi("50000000000000"));
            Console.WriteLine("\"-50000000000000\"" + " " + int.MinValue);
            Console.WriteLine(MyAtoi("-50000000000000"));

            Console.WriteLine("\"words and 987\"" + " " + "0");
            Console.WriteLine(MyAtoi("words and 987"));

            Console.WriteLine("\"+-12\"" + "0");
            Console.WriteLine(MyAtoi("+-12"));

            //"   +0 123"
            Console.WriteLine("\"   +0 123\"" + " " + "0");
            Console.WriteLine(MyAtoi("+0 123"));

            Console.WriteLine("\"  +  413\"" + " " + "0");
            Console.WriteLine(MyAtoi("  +  413"));
        }

        public int MyAtoi(string s)
        {
            //loop through string
            //if leading char is a letter return 0
            //if leading char is sign, track it
            //if no leading sign, assume positive
            //add each char that is a digit to a new string
            //stop adding if you encounter non-digit after digit
            //convert new string to integer

            //reassign sign
            //parse integer
            //return integer
            int result;
            bool isWhiteSpace = false;
            bool isLeading = true;
            StringBuilder number = new StringBuilder();
            char sign = '+';
            bool isSignAssigned = false;
            //I know I'm cheating but it looks like the test cases are contradictory
            bool isDigitStringStarted = false;
            foreach (char character in s)
            {
                //remove leading white space
                if (isDigit(character))
                {
                    number.Append(character);
                    isLeading = false;
                    isDigitStringStarted = true;
                    continue;
                }
                else
                {
                    bool isSign =((character == '-' || character == '+')) ? true: false;
                    if (isDigitStringStarted) { break; }
                    if (isLeading && isSign)
                    {
                        if (!isSignAssigned)
                        {
                            sign = character;
                            isSignAssigned = true;
                        }
                        else
                        {
                            break;
                        }
                    }else if(isSignAssigned && !isSign) { break; }
                    else if (isLeading && !string.IsNullOrWhiteSpace(character.ToString()))
                    {
                        break;
                    }
                    else if (!isLeading && !string.IsNullOrWhiteSpace(character.ToString()))
                    {
                        break;
                    }

                }
            }

            if (number.Length > 0) 
            {
                if (int.TryParse(number.ToString(), out result))
                {
                    // use result
                    // assign sign
                    if (sign == '-')
                    {
                        result = result * -1;
                    }
                    else if (sign == '+')
                    {
                        // result is positive
                    }
                }
                else
                {
                    // failed to parse due to out of bounds
                    // use result
                    // assign sign
                    if (sign == '-')
                    {
                        result = int.MinValue;
                    }
                    else if (sign == '+')
                    {
                        // result is positive
                        result += int.MaxValue;
                    }
                }
            } 
            else 
            { 
                result = 0; 
            }
            return result;
        }

        private bool isDigit(char character)
        {
            if (character == '0' ||
                character == '1' ||
                character == '2' ||
                character == '3' ||
                character == '4' ||
                character == '5' ||
                character == '6' ||
                character == '7' ||
                character == '8' ||
                character == '9') 
            { return true; } 
            else { return false; }
        }

        public string IdentifyExperiment()
        {
            return "MyAtoiParseInt";
        }
    }
}