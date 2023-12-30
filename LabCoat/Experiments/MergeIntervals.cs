using System.Collections.Generic;
using System;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class MergeIntervals : IExperiment
    {
        public void Experiment()
        {
            List<int[]> intervals = new List<int[]> {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };

            var merged = this.MergeTheIntervals(intervals);
            foreach (var interval in merged)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");
            }
        }

        private List<int[]> MergeTheIntervals(List<int[]> intervals)
        {
            // Your code here
            List<int[]> result = new List<int[]>();
            int counter = 0;
            foreach (int[] interval in intervals)
            {
                int secondNumberInFirstInterval = interval[1];
                if (counter + 1 < intervals.Count)
                {
                    int firstNumberInSecondInterval = intervals.ElementAt(counter + 1)[0];
                    if (secondNumberInFirstInterval >= firstNumberInSecondInterval)
                    {
                        int[] newItem = new int[] { interval[0], intervals.ElementAt(counter + 1)[1] };
                        result.Add(newItem);
                    }
                    else
                    {
                        result.Add(intervals.ElementAt(counter + 1));
                    }
                }
                counter++;
            }
            return result;
        }

        public string IdentifyExperiment()
        {
            return "MergeIntervals";
        }
    }
}