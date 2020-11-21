using Sandbox.Activities;
using System;

namespace Sandbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Put all your experiments in the factory class.
            ExperimentFactory factory = new ExperimentFactory();
            bool keepGoing = true;

            while (keepGoing)
            {
                try
                {
                    IExperiment experiment = factory.ChooseExperiment();

                    Console.WriteLine("Running: " + experiment.Identify());

                    experiment.Execute();

                    Console.WriteLine();
                    keepGoing = PromptKeepGoing();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your experiment caused an error: " + ex.Message);
                    if (!string.IsNullOrWhiteSpace(ex.StackTrace))
                    {
                        string line = ex.StackTrace.Substring(ex.StackTrace.IndexOf(".cs:", 0, ex.StackTrace.Length, StringComparison.InvariantCulture) + 4, 10);
                        Console.WriteLine("Line in your experiment class: " + line);
                    }
                    keepGoing = PromptKeepGoing();
                }
            }
        }

        private static bool PromptKeepGoing()
        {
            bool keepGoing = true;
            Console.Write("Keep going? ");
            var input = Console.ReadKey();
            if (input.KeyChar != 'y')
            {
                keepGoing = false;
            }
            Console.WriteLine();
            return keepGoing;
        }
    }
}