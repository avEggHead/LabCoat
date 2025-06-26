using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System;

namespace LabCoat.Experiments
{
    internal class ProblemFromLeet : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("Input: aa, a Expected: false");
            Console.WriteLine($"actual: {isMatch("aa","a")}");

            Console.WriteLine("Input: aa, a* Expected: true");
            Console.WriteLine($"actual: {isMatch("aa", "a*")}");

            Console.WriteLine("Input: ab, .* Expected: true");
            Console.WriteLine($"actual: {isMatch("ab", ".*")}");

            Console.WriteLine("Input: ab, .*c Expected: false");
            Console.WriteLine($"actual: {isMatch("ab", ".*c")}");

            Console.WriteLine("Input: aaa, a*a Expected: true");
            Console.WriteLine($"actual: {isMatch("aaa", "a*a")}");

            Console.WriteLine("Input: aaaaaaaa, a*a Expected: true");
            Console.WriteLine($"actual: {isMatch("aaaaaaaa", "a*a")}");

            Console.WriteLine("Input: aab, c*a*b Expected: true");
            Console.WriteLine($"actual: {isMatch("aab", "c*a*b")}");

            Console.WriteLine("Input: aaaaaabc, a*abc Expected: true");
            Console.WriteLine($"actual: {isMatch("aaaaaabc", "a*abc")}");
        }
        
        public bool isMatch(string s, string p)
        {
            int indexOfString = 0;
            bool reachedEndOfString = false;
            bool reachedEndOfPattern = false;
            bool wasLoopMatched = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (reachedEndOfString && reachedEndOfPattern ) {

                    break; 
                }
                if (i == p.Length - 1) { reachedEndOfPattern = true; }
                bool isLast = (i == p.Length - 1) ? true : false;
                if (p[i] == '*' && wasLoopMatched)
                {
                    indexOfString--;
                    continue;
                }
                else if (p[i] == '*') 
                {
                    // these we want to skip to the next part of the pattern;
                    continue;
                }

                if (indexOfString == s.Length - 1) 
                {
                    reachedEndOfString = true;
                    break; 
                }
                char emptyChar = default;
                char nextChar = (isLast) ? emptyChar : p[i + 1];
                if (nextChar == '*')
                {
                    if (s[indexOfString] != p[i] && p[i] != '.') { continue; } // pattern didn't match but you want to go to the next
                    //pattern, don't advance the string, because when * it could be zero
                    while (s[indexOfString] == p[i] || p[i] == '.') 
                    { 
                        indexOfString++;
                        wasLoopMatched = true;
                        if (indexOfString == s.Length)
                        {
                            reachedEndOfString = true;
                            break;
                        }
                    }
                }
                else
                {
                    if (p[i] == '.')
                    {
                        indexOfString++;
                        if (indexOfString == s.Length)
                        {
                            reachedEndOfString = true;
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        if (p[i] == s[indexOfString])
                        {
                            indexOfString++;
                            if (indexOfString == s.Length)
                            {
                                reachedEndOfString = true;
                                break;
                            }
                            continue;
                        }
                        else { return false; }
                    }
                }
            }

            return reachedEndOfString && reachedEndOfPattern;
        }

        public string IdentifyExperiment()
        {
            return "New Problem";
        }
    }
}