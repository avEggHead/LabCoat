using Sandbox.Experiments;
using System;

namespace Sandbox
{
    internal class Sandbox
    {
        private bool run = true;

        private ExperimentFactory factory;

        public Sandbox(ExperimentFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            while (this.run)
            {
                try
                {
                    IExperiment experiment = factory.SelectExperiment();

                    if (experiment != null)
                    {
                        this.RunExperiment(experiment);
                    }
                    else
                    {
                        this.HandleExperimentNotFound();
                    }
                }
                catch (Exception ex)
                {
                    this.HandleErrorInExperiment(ex);
                }
            }
        }

        private void HandleExperimentNotFound()
        {
            Console.WriteLine("Experiment not found.");
            this.run = PromptKeepGoing();
        }

        private void HandleErrorInExperiment(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error in experiment. ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Message: " + ex.Message);
            Console.ResetColor();
            if (!string.IsNullOrWhiteSpace(ex.StackTrace))
            {
                string line = ex.StackTrace.Substring(ex.StackTrace.IndexOf(".cs:", 0, ex.StackTrace.Length, StringComparison.InvariantCulture) + 4, 10);
                Console.Write("Line in your experiment class: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(line);
                Console.ResetColor();
            }
            this.run = PromptKeepGoing();
        }

        private void RunExperiment(IExperiment experiment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Running: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(experiment.Identify());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start of Experiment Output: ");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.ResetColor();

            experiment.Execute();

            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================================");
            Console.WriteLine("End of Experiment Output: ");
            Console.WriteLine();
            Console.ResetColor();

            this.run = PromptKeepGoing();
        }

        private bool PromptKeepGoing()
        {
            bool keepGoing = true;
            Console.Write("Keep going? (yes/no)");
            Console.WriteLine();
            Console.Write("> ");

            var input = Console.ReadLine();
            if (!input.Contains("y"))
            {
                keepGoing = false;
            }
            Console.WriteLine();
            Console.Clear();

            return keepGoing;
        }
    }
}