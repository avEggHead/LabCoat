using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class DivisionWithoutDividing : IExperiment
    {
        public void Experiment()
        {
            var result1 = Divide(10, 3);

            Console.WriteLine("Expected: 3");
            Console.WriteLine($"Actual: {result1}");

            var result2 = Divide(10, 2);

            Console.WriteLine("Expected: 5");
            Console.WriteLine($"Actual: {result2}");

            var result3 = Divide(30, 4);

            Console.WriteLine("Expected: 7");
            Console.WriteLine($"Actual: {result3}");

            var result4 = Divide(7, -3);

            Console.WriteLine("Expected: -2");
            Console.WriteLine($"Actual: {result4}");

            var result5 = Divide(-2147483648, -1);

            Console.WriteLine("Expected: 2147483648");
            Console.WriteLine($"Actual: {result5}");
        }

        public Int64 Divide(int dividend, int divisor)
        {
            Int64 bigDividend = dividend;
            bool isNegative = false;
            if ((bigDividend < 0 && divisor > 0) || (divisor < 0 && bigDividend >= 0))
            {
                isNegative = true;
            }

            if (bigDividend < 0 )
            {
                bigDividend = bigDividend - bigDividend - bigDividend;
            }

            if (divisor < 0)
            {
                divisor = divisor - divisor - divisor;
            }

            if (divisor == 1)
            {
                if (isNegative) 
                {
                    return -bigDividend;  
                }
                return bigDividend;
            }

            int result = 0;
            List<int> groups = new List<int>();

            for (int i = 0; i < divisor; i++)
            {
                int group = 0;
                groups.Add(group);
            }

            while (bigDividend > 0 && bigDividend >= groups.Count)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    int group = groups[i];
                    group++;
                    groups[i] = group;
                    bigDividend--;
                }
            }

            result = FindSmallestNumber(groups);

            if (isNegative)
            {
                result = -result;
            }

            return result;
        }

        private int FindSmallestNumber(List<int> groups)
        {
            int compareToMe = int.MaxValue;
            foreach (int group in groups)
            {
                if (group < compareToMe)
                {
                    compareToMe = group;
                }
            }
            return compareToMe;
        }

        public string IdentifyExperiment()
        {
            return "DivisionWithoutDividing";
        }
    }
}