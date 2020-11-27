using System;
using System.ComponentModel;
using System.Drawing;

namespace LabCoat.Experiments
{
    public class ExampleExperiment : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("Example Output");
        }

        public string IdentifyExperiment()
        {
            return nameof(ExampleExperiment);
        }
    }
}