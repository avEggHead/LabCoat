using System;

namespace CSharpEight
{
    internal class Factory
    {
        internal IExecute ChooseActivity()
        {
            Console.WriteLine("Choose Activity: ");
            var choice = Console.ReadKey();
            Console.WriteLine(choice);

            return this.GetActivityClass(choice);
        }

        // Put all the classes you want to experiment with here.
        // when you execute the program type in the number that
        // matches their case in the switch.
        private IExecute GetActivityClass(ConsoleKeyInfo choice)
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
            }
            return null;
        }
    }
}