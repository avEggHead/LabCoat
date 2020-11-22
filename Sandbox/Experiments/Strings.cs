using System;
using System.Text;

namespace Sandbox.Experiments
{
    internal class Strings : IExperiment
    {
        public void Execute()
        {
            var symbol = 'a';

            Console.WriteLine(char.IsLetter(symbol));
            Console.WriteLine(char.IsUpper(symbol));
            Console.WriteLine(new string('a', char.IsLetter(symbol).ToString().Length));

            var str = "abcd1234";

            Console.WriteLine(str[2]);

            foreach (var thing in str)
            {
                Console.Write(thing + ",");
            }

            var str2 = "there,isad,one,porr";
            string[] sections = str2.Split(',');
            foreach (string word in sections)
            {
                Console.Write(word + "|");
            }

            Console.WriteLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 51; i++)
            {
                sb.Append(i).Append('|');
            }

            Console.WriteLine(sb.ToString());

            Encoding encoding = Encoding.UTF8;

            Console.WriteLine(encoding);

            this.PrintMessageOnScreen("greetings");
        }

        public string Identify()
        {
            return typeof(Strings).Name;
        }

        private void PrintMessageOnScreen(string message)
        {
            Console.WriteLine(message);
        }
    }
}