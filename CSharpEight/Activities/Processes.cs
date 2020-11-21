using System.Diagnostics;

namespace CSharpEight.Activities
{
    internal class Processes : IRunExperiment
    {
        public void Execute()
        {
            Process.Start("notepad.exe");
        }
    }
}