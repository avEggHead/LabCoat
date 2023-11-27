using System;
using System.CodeDom.Compiler;

namespace LabCoat.Experiments
{
    internal class IntegerDivision : IExperiment
    {
        public void Experiment()
        {
            int firstInt = 120;

            int result = 140 / 200;

            Console.WriteLine(result);
        }

        public string IdentifyExperiment()
        {
            return "IntegerDivision";
        }
    }
}