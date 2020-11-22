namespace Sandbox.Activities
{
    using System;

    internal class PrintingInDifferentColors : IExperiment
    {
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("This should be read in red");
            Console.ResetColor();
        }

        public string Identify()
        {
            return typeof(PrintingInDifferentColors).Name;
        }
    }
}