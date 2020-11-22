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
                Console.Clear();
                try
                {
                    IExperiment experiment = factory.ChooseExperiment();

                    if (experiment != null)
                    {
                        Console.WriteLine("Running: " + experiment.Identify());

                        experiment.Execute();

                        Console.WriteLine();
                        keepGoing = PromptKeepGoing();
                    }
                    else
                    {
                        Console.WriteLine("Experiment not found.");
                        keepGoing = PromptKeepGoing();
                    }
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
            Console.Write("Keep going? (yes/no)");
            Console.WriteLine();
            Console.Write("> ");

            var input = Console.ReadLine();
            if (!input.Contains("yes"))
            {
                keepGoing = false;
            }
            Console.WriteLine();
            return keepGoing;
        }
    }
}