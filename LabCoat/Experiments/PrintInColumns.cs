using System;

namespace LabCoat.Experiments
{
    internal class PrintInColumns : IExperiment
    {
        public void Experiment()
        {
            var topOfColumns = Console.CursorTop;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Column One");
            }

            Console.CursorTop = topOfColumns;
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(15, topOfColumns);
                Console.WriteLine("Column Two");
                topOfColumns++;
            }

            // get the current cursor vertical and print it
            var currentCursorVertical = Console.CursorTop;
            Console.WriteLine(currentCursorVertical);
        }

        public string IdentifyExperiment()
        {
            return nameof(PrintInColumns);
        }
    }
}