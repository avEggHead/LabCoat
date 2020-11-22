using System.Diagnostics;

namespace Sandbox.Experiments
{
    internal class Processes : IExperiment
    {
        public void Execute()
        {
            Process.Start("notepad.exe");
        }

        public string Identify()
        {
            return typeof(Processes).Name;
        }
    }
}