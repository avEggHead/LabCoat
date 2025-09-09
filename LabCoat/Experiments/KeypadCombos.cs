using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class KeypadCombos : IExperiment
    {
        public void Experiment()
        {
            var output = LetterCombinations("");
            foreach (var item in output) 
            {
                Console.WriteLine(item);
            }
        }

        public IList<string> LetterCombinations(string digits)
        {
            if(digits == "") { return new List<string>(); }
            Dictionary<int, string> keypad = new Dictionary<int, string>()
            {
                {2,"abc"},{3,"def"},{4,"ghi"},{5,"jkl"},{6,"mno"},{7,"pqrs"},{8,"tuv"},{9,"wxyz"}
            };
            IList<string> list = new List<string>();
            var digitList = new List<int>();
            var charList = new List<string>();
            foreach (var digit in digits)
            {
                var splitNumber = digit.ToString();
                var number = int.Parse(digit.ToString());
                charList.Add(keypad[number]);
            }

            int indexer = 1;
            //foreach (var setOfChars in charList)
            //{
                foreach (var letter in charList[0])
                {
                    var s = letter.ToString();
                    if (charList.Count > indexer)
                    {
                        var nextSetOfChars1 = charList[indexer];
                        indexer++;
                        var lastOfSet1 = nextSetOfChars1.TakeLast(1).FirstOrDefault().ToString();
                        foreach (var nextLetter1 in nextSetOfChars1)
                        {
                            var nextS1 = s + nextLetter1.ToString();
                            if (charList.Count > indexer)
                            {
                                var nextSetOfChars2 = charList[indexer];
                                indexer++;
                                var lastOfSet2 = nextSetOfChars2.TakeLast(1).FirstOrDefault().ToString();
                                foreach (var nextLetter2 in nextSetOfChars2)
                                {
                                    var nextS2 = nextS1 + nextLetter2.ToString();
                                    if (charList.Count > indexer)
                                    {
                                        var nextSetOfChars3 = charList[indexer];
                                        indexer++;
                                        var lastOfSet3 = nextSetOfChars3.TakeLast(1).FirstOrDefault().ToString();
                                        foreach (var nextLineLetter3 in nextSetOfChars3)
                                        {
                                            var nextS3 = nextS2 + nextLineLetter3.ToString();
                                            list.Add(nextS3);
                                            if (nextLineLetter3.ToString() == lastOfSet3)
                                            {
                                                indexer--;
                                            }
                                        }
                                    } 
                                    else
                                    {
                                        list.Add(nextS2);
                                    }
                                    if (nextLetter2.ToString() == lastOfSet2)
                                    {
                                        indexer--;
                                    }
                                }
                            }
                            else
                            {
                                list.Add(nextS1);
                            }
                            if (nextLetter1.ToString() == lastOfSet1)
                            {
                                indexer--;
                            }
                        }
                    }
                    else
                    {
                        list.Add(s);
                    }
                //}
            }
            return list;
        }

        public string IdentifyExperiment()
        {
            return "KeypadCombos";
        }
    }
}