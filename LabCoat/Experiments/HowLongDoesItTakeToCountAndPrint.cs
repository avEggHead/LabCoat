using System;

namespace Sandbox.Experiments
{
    internal class HowLongDoesItTakeToCountAndPrint : IExperiment
    {
        public void Experiment()
        {
            for (int i = 0; i < 50000; i++)
            {
                Console.Write(i + " ");
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(HowLongDoesItTakeToCountAndPrint);
        }
    }
}