namespace LabCoat.Experiments
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    // Put all your experiment classes in the ExperimentBook.
    // when you execute the program type in the number that
    // matches its key in the dictionary.
    // Each experiment should implement IExperiment
    // and the Execute() method is the entry point to the class.
    public class Laboratory
    {
        public Dictionary<int, IExperiment> ExperimentBook = new Dictionary<int, IExperiment>
        {
            { 1, new Converters() },
            { 2, new Strings() },
            { 3, new Processes() },
            { 4, new DataTableExperiments() },
            { 5, new ThrowsException() },
            { 6, new PrintingInDifferentColors() },
            { 7, new XMLSandbox() },
            { 8, new ConsoleTesting() },
            { 9, new HowLongDoesItTakeToCountAndPrint() },
            { 10, new RunningAWhileLoop() },
            { 11, new HowDoDelegatesWork() },
            { 12, new CryptographyHowItWorks() },
            { 13, new ByteArrayExperiments()},
            { 14, new HashingTest() },
            { 15, new SystemInfoTesting() },
            { 16, new ThreadingFun()},
            { 17, new WorkingWithJSON() },
            { 18, new PrintInColumns() },
            { 19, new JsonSerializationExperiment() },
            { 20, new PrintInColumns() },
            { 21, new PrintInColumns() },
            { 22, new PrivateMethodTesting() },
        };

        public IExperiment SelectExperiment()
        {
            this.DisplayExperimentBookContents();
            return this.GetExperimentClass();
        }

        private void DisplayExperimentBookContents()
        {
            Console.WriteLine("Choose Experiment: (type the number and hit Enter)");
            var topOfCOlumns = Console.CursorTop;
            var topOfCOlumns2 = Console.CursorTop;
            var trackNumberOfExperiments = 0;
            foreach (var key in this.ExperimentBook.Keys)
            {
                Thread.Sleep(10);
                if (trackNumberOfExperiments >= 10)
                {
                    Console.SetCursorPosition(40, topOfCOlumns);
                    topOfCOlumns++;
                }
                if (trackNumberOfExperiments >= 20)
                {
                    Console.SetCursorPosition(80, topOfCOlumns2);
                    topOfCOlumns2++;
                }
                Console.WriteLine(key + ". " + this.ExperimentBook[key].ToString().Replace("LabCoat.Experiments.", ""));
                trackNumberOfExperiments++;
            }
            Console.SetCursorPosition(0, 11);
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