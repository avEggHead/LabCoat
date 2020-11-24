using Sandbox.Experiments;
using System;

namespace Sandbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // All you have to do is put new experiment classes in the ExperimentFactory.
            Laboratory lab = new Laboratory();
            Scientist scientist = new Scientist(lab);
            scientist.GoIntoLab();
        }
    }
}