using System;

namespace CSharpEight
{
    internal class Factory
    {
        public Factory()
        {
        }

        internal IExecute ChooseDoer()
        {
            Console.WriteLine("Choose doer: ");
            var choice = Console.ReadKey();
            Console.WriteLine(choice);
            return this.GetDoerClass(choice);
        }

        private IExecute GetDoerClass(ConsoleKeyInfo choice)
        {
            switch (choice.KeyChar)
            {
                case '1':
                    return new Converters();

                case '2':
                    return new StringSandBox();
            }
            return null;
        }
    }
}