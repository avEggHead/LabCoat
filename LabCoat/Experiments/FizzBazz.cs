using System;

namespace LabCoat.Experiments
{
    internal class FizzBazz : IExperiment
    {
        public void Experiment()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = false;
                bool buzz = false;
                bool bazz = false;
                if (i % 3 == 0)
                {
                Console.Write("Fizz");
                    fizz = true;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    buzz = true;
                }
                if (i % 7 == 0)
                {
                    Console.Write("Bazz");
                    bazz = true;
                }
                if (!fizz && !buzz && !bazz)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }

        public string IdentifyExperiment()
        {
            return "FizzBazz";
        }
    }
}