using System;

namespace LabCoat.Experiments
{
    internal class FixTheBugs : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine(Average(9, 2));

        }

        public static double Average(int a, int b)
        {
            double c = ((double)a + (double)b) / (double)2m;
            return c;
        }

        public string IdentifyExperiment()
        {
            return "FixBugs";
        }
    }
}