using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class CheckingCountProperty : IExperiment
    {
        public void Experiment()
        {
            List<string> list = new List<string>();

            list.Add("String1");
            list.Add("String2");
            int initialListCount = list.Count;
            Console.WriteLine(list.Count);
            Console.WriteLine(initialListCount);
            list.Remove("String1");
            int finalListCount = list.Count;
            Console.WriteLine(finalListCount);
            Console.WriteLine(initialListCount);
            Console.WriteLine(list.Count);

        }

        public string IdentifyExperiment()
        {
            return "CheckingCountProperty";
        }
    }
}