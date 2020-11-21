using System.Diagnostics;

namespace Sandbox.Activities
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