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
            Console.WriteLine("Your experiment caused an error: " + ex.Message);
            if (!string.IsNullOrWhiteSpace(ex.StackTrace))
            {
                string line = ex.StackTrace.Substring(ex.StackTrace.IndexOf(".cs:", 0, ex.StackTrace.Length, StringComparison.InvariantCulture) + 4, 10);
                Console.WriteLine("Line in your experiment class: " + line);
            }
            this.run = PromptKeepGoing();
        }

        private void RunExperiment(IExperiment experiment)
        {
            Console.WriteLine("Running: " + experiment.Identify());

            experiment.Execute();

            Console.WriteLine();
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