namespace LabCoat.Experiments
{
    using System;
    using System.Collections.Generic;

    // Put all your experiment classes in the ExperimentBook.
    // when you execute the program type in the number that
    // matches its key in the dictionary.
    // Each experiment should implement IExperiment
    // and the Execute() method is the entry point to the class.
    public class Laboratory
    {
        public Dictionary<int, IExperiment> ExperimentBook = new Dictionary<int, IExperiment>
        {
            {1, new ExampleExperiment() },
            {2, new CastEnumToNull() },
            {3, new DateTimeParsing() },
            {4, new IntegerDivision() },
            {5, new DelegateExp() },
            {6, new CovarianceDelegate() },
            {7, new ParseIntNull() },
            {8, new RotateArray() },
            {9, new MergeIntervals() },
            {10, new PalindromeDetector() },
            {11, new FindMissingNumber() },
            {12, new LongestConsecutiveElements() },
            {13, new IsWeirdStringValid() },
            {14, new MaxSubArraySum() },
            {15, new FirstUniqueChar() },
        };

        public IExperiment SelectExperiment()
        {
            this.DisplayExperimentBookContents();
            return this.GetExperimentClass();
        }

        private void DisplayExperimentBookContents()
        {
            Console.WriteLine("Choose Experiment: (type the number and hit Enter)");
            foreach (var key in this.ExperimentBook.Keys)
            {
                Console.WriteLine(key + ". " + this.ExperimentBook[key].ToString().Replace("LabCoat.Experiments.", ""));
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