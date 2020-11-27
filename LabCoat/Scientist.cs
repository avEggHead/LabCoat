using LabCoat.Experiments;
using System;
using System.Diagnostics;
using System.Threading;

namespace LabCoat
{
    internal class Scientist
    {
        private bool IsExperimenting = true;

        private Laboratory lab;

        public Scientist(Laboratory lab)
        {
            this.lab = lab;
        }

        public void GoIntoLab()
        {
            while (this.IsExperimenting)
            {
                try
                {
                    IExperiment experiment = lab.SelectExperiment();

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
                finally
                {
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
            // leave lab
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LabCoat by Clinton Avery is licensed under a Creative Commons Attribution 4.0 International License. Feel free to clone, fork, and star the repo https://github.com/avEggHead/LabCoat.");
            Console.ResetColor();
        }

        private void HandleExperimentNotFound()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Experiment not found.");
            Console.ResetColor();
            this.IsExperimenting = PromptKeepGoing();
        }

        private void HandleErrorInExperiment(Exception ex)
        {
            if (Console.CursorLeft > 0)
            {
                Console.WriteLine();
            }
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
            this.IsExperimenting = PromptKeepGoing();
        }

        private void RunExperiment(IExperiment experiment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Running: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(experiment.IdentifyExperiment());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***Start of Experiment Output***");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.ResetColor();
            var cursorSize = Console.CursorSize;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            experiment.Experiment();
            timer.Stop();

            Console.ResetColor();
            Console.CursorSize = cursorSize;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=================================");
            Console.WriteLine("***End of Experiment Output*** ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elapsed Time: " + timer.ElapsedMilliseconds + " ms");
            Console.ResetColor();
            Console.WriteLine();

            this.IsExperimenting = PromptKeepGoing();
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