using System;
using System.Collections.Generic;

namespace LabCoat.Experiments
{
    internal class IteratorMethods : IExperiment
    {
        public void Experiment()
        {
            foreach (var item in StringCollection())
            {
                Console.WriteLine(item);
            }

            foreach (var number in IntCollection())
            {
                Console.WriteLine(number);
            }
            //Console.WriteLine(StringCollection());
        }

        public IEnumerable<string> StringCollection()
        {
            yield return "hello";
            yield return "how";
            yield return "are";
            yield return "you?";
        }

        public IEnumerable<int> IntCollection()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return i;
            }
        }

        public string IdentifyExperiment()
        {
            return "IteratorMethods";
        }
    }
}