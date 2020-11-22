using Sandbox.Experiments;
using System;

namespace Sandbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // All you have to do is put new experiment classes in the ExperimentFactory.
            ExperimentFactory factory = new ExperimentFactory();

            Sandbox sandbox = new Sandbox(factory);
            sandbox.Run();
        }
    }
}