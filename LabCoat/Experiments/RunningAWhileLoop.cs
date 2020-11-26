using System;

namespace Sandbox.Experiments
{
    internal class RunningAWhileLoop : IExperiment
    {
        public void Experiment()
        {
            System.Console.WriteLine("How many lines should we print?");
            int numberOfLines = Int32.Parse(System.Console.ReadLine());

            int tracker = 0;
            do
            {
                System.Console.WriteLine((tracker + 1) + " hello");
                tracker++;
                if (tracker == 25)
                {
                    throw new StackOverflowException();
                }
            } while (tracker < numberOfLines);
        }

        public string IdentifyExperiment()
        {
            return nameof(RunningAWhileLoop);
        }
    }
}