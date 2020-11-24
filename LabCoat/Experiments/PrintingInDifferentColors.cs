namespace Sandbox.Experiments
{
    using System;

    internal class PrintingInDifferentColors : IExperiment
    {
        public void Experiment()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("This should be read in red");
            Console.ResetColor();
        }

        public string IdentifyExperiment()
        {
            return typeof(PrintingInDifferentColors).Name;
        }
    }
}