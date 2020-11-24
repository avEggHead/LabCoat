using System.Diagnostics;

namespace Sandbox.Experiments
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