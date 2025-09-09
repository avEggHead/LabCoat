using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class ParenthesesValidator : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("Expected True.  Actual: " + IsValid("()"));
            Console.WriteLine("Expected True.  Actual: " + IsValid("()()()"));
            Console.WriteLine("Expected True.  Actual: " + IsValid("()[()]()"));
            Console.WriteLine("Expected False. Actual: " + IsValid("))[()]()"));
            Console.WriteLine("Expected False.  Actual: " + IsValid("([)]"));

            Console.WriteLine("New method");
            Console.WriteLine("Expected True.  Actual: " + isReallyValid("()"));
            Console.WriteLine("Expected True.  Actual: " + isReallyValid("()()()"));
            Console.WriteLine("Expected True.  Actual: " + isReallyValid("()[()]()"));
            Console.WriteLine("Expected False. Actual: " + isReallyValid("))[()]()"));
            Console.WriteLine("Expected False.  Actual: " + isReallyValid("([)]"));
            Console.WriteLine("Expected False.  Actual: " + isReallyValid("["));
        }

        public bool isReallyValid(string s)
        {
            Stack<string> stack = new Stack<string>();

            foreach(char bracket in s)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    stack.Push(bracket.ToString());
                }
                else
                {
                    if(stack.Count == 0) { return false; }   
                    var openBracket = stack.Pop();
                    if (openBracket == "(" && bracket != ')')
                    {
                        return false;
                    }
                    if (openBracket == "[" && bracket != ']')
                    {
                        return false;
                    }
                    if (openBracket == "{" && bracket != '}')
                    {
                        return false;
                    }
                }
            }

            return (stack.Count == 0) ? true: false;
        }

        public bool IsValid(string s)
        {
            List<int> openParenthesesIndexes = new List<int>();
            List<int> openBracketIndexes = new List<int>();
            List<int> openCurlyBraceIndexes = new List<int>();
            List<int> closeParenthesesIndexes = new List<int>();
            List<int> closeBracketIndexes = new List<int>();
            List<int> closeCurlyBraceIndexes = new List<int>();
            Stack<string> stack = new Stack<string>();


            for (int i = 0; i < s.Length; i++)
            {
                var firstBracket = s[i];
                if (firstBracket == '(' || firstBracket == '[' || firstBracket == '{')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        var secondBracket = s[j];

                        switch (firstBracket) 
                        {
                            case '(':
                                if (secondBracket == ')' && !closeParenthesesIndexes.Contains(j))
                                {
                                    openParenthesesIndexes.Add(i);
                                    closeParenthesesIndexes.Add(j);
                                };
                                break;
                            case '[':
                                if (secondBracket == ']' && !closeParenthesesIndexes.Contains(j))
                                {
                                    openBracketIndexes.Add(i);
                                    closeBracketIndexes.Add(j);
                                };
                                break;
                            case '{':
                                if (secondBracket == '}' && !closeParenthesesIndexes.Contains(j))
                                {
                                    openCurlyBraceIndexes.Add(i);
                                    closeCurlyBraceIndexes.Add(j);
                                };
                                break;
                        }

                    }
                }
                else
                {
                    if (closeParenthesesIndexes.Contains(i) || closeBracketIndexes.Contains(i) || closeCurlyBraceIndexes.Contains(i))
                    {
                        continue;
                    } else
                    {
                        return false;
                    }
                }
            }

            int totalIndexes = closeBracketIndexes.Count + closeCurlyBraceIndexes.Count + closeParenthesesIndexes.Count
                + openBracketIndexes.Count + openCurlyBraceIndexes.Count + openParenthesesIndexes.Count;

            if(totalIndexes == s.Length)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string IdentifyExperiment()
        {
            return "ParenthesesValidator";
        }
    }
}