using System;
using System.Collections.Generic;

namespace Sandbox.Activities
{
    // Put all your experiment classes in the ExperimentBook dictionary.
    // when you execute the program type in the number that
    // matches its key in the dictionary.
    // Each experiment should implement IExperiment
    // and the Execute() method is the entry point to the class.
    public class ExperimentFactory
    {
        public Dictionary<int, IExperiment> ExperimentBook = new Dictionary<int, IExperiment>
        {
            { 1, new Converters() },
            { 2, new StringSandBox() },
            { 3, new Processes() },
            { 4, new DataTableExperiments() },
            { 5, new ThrowsException() },
            { 6, new PrintingInDifferentColors() },
        };

        public IExperiment ChooseExperiment()
        {
            Console.WriteLine("Choose Experiment: ");
            this.DisplayExperiments();
            Console.Write("> ");

            var choice = Console.ReadLine();
            Console.WriteLine();
            return this.GetExperimentClass(choice);
        }

        private void DisplayExperiments()
        {
            foreach (var key in this.ExperimentBook.Keys)
            {
                Console.WriteLine(key + ". " + this.ExperimentBook[key].ToString().Replace("Sandbox.Activities.", ""));
            }
        }

        private IExperiment GetExperimentClass(string choice)
        {
            IExperiment experiment = default(IExperiment);
            bool exists = this.ExperimentBook.TryGetValue(Int32.Parse(choice), out experiment);
            if (exists)
            {
                return experiment;
            }
            else
            {
                return null;
            }
        }
    }
}