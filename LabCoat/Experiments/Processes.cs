using System.Diagnostics;

namespace LabCoat.Experiments
{
    internal class Processes : IExperiment
    {
        public void Experiment()
        {
            Process.Start("notepad.exe");
        }

        public string IdentifyExperiment()
        {
            return typeof(Processes).Name;
        }
    }
}