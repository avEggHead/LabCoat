using System.Diagnostics;

namespace CSharpEight.Activities
{
    internal class Processes : IExecute
    {
        public void Execute()
        {
            Process.Start("notepad.exe");
        }
    }
}