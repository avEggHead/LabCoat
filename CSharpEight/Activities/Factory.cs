using System;

namespace Sandbox.Activities
{
    public class ExperimentFactory
    {
        public IExperiment ChooseExperiment()
        {
            Console.WriteLine("Choose Activity: ");
            var choice = Console.ReadKey();
            Console.WriteLine();
            return this.GetActivityClass(choice);
        }

        // Put all the classes you want to experiment with here.
        // when you execute the program type in the number that
        // matches their case in the switch.
        // Each of the experiment class should implement the IExecute
        // Interface and the Execute() method is the entry point to the class.
        private IExperiment GetActivityClass(ConsoleKeyInfo choice)
        {
            switch (choice.KeyChar)
            {
                case '1':
                    return new Converters();

                case '2':
                    return new StringSandBox();

                case '3':
                    return new Processes();

                case '4':
                    return new DataTableExperiments();

                case '5':
                    return new ThrowsException();
            }
            return null;
        }
    }
}