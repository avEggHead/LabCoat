using System.Diagnostics;

namespace CSharpEight
{
    internal class Processes : IExecute
    {
        public void Execute()
        {
            Process.Start("notepad.exe");
        }
    }
}