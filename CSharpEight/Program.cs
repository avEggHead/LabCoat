using CSharpEight.Activities;
using System;
using System.Text;

namespace CSharpEight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                // Put all of your experiments in the factory class.
                ExperimentFactory factory = new ExperimentFactory();

                IExecute activity = factory.ChooseActivity();

                try
                {
                    activity.Execute();

                    Console.WriteLine();
                    keepGoing = AskToKeepGoing();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your experiment caused an error: " + ex.Message);
                    keepGoing = AskToKeepGoing();
                }
            }
        }

        private static bool AskToKeepGoing()
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