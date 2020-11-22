using Sandbox.Experiments;
using System;
using System.Collections.Generic;

namespace Sandbox
{
    // Put all your experiment classes in the ExperimentBook.
    // when you execute the program type in the number that
    // matches its key in the dictionary.
    // Each experiment should implement IExperiment
    // and the Execute() method is the entry point to the class.
    public class ExperimentFactory
    {
        public Dictionary<int, IExperiment> ExperimentBook = new Dictionary<int, IExperiment>
        {
            { 1, new Converters() },
            { 2, new Strings() },
            { 3, new Processes() },
            { 4, new DataTableExperiments() },
            { 5, new ThrowsException() },
            { 6, new PrintingInDifferentColors() },
        };

        public IExperiment SelectExperiment()
        {
            this.DisplayExperimentMenu();
            return this.GetExperimentClass();
        }

        private void DisplayExperimentMenu()
        {
            Console.WriteLine("Choose Experiment: (type the number and hit Enter)");
            foreach (var key in this.ExperimentBook.Keys)
            {
                Console.WriteLine(key + ". " + this.ExperimentBook[key].ToString().Replace("Sandbox.Experiments.", ""));
            }
            Console.Write("> ");
        }

        private IExperiment GetExperimentClass()
        {
            var choice = Console.ReadLine();
            Console.WriteLine();
            IExperiment experiment = default(IExperiment);
            int choiceInt = default(int);
            bool isChoiceInt = Int32.TryParse(choice, out choiceInt);
            if (isChoiceInt)
            {
                bool exists = this.ExperimentBook.TryGetValue(choiceInt, out experiment);
                if (exists)
                {
                    return experiment;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}