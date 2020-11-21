using System;

namespace CSharpEight.Activities
{
    internal class ThrowsException : IRunExperiment
    {
        public void Execute()
        {
            throw new ExecutionEngineException("hello");
        }
    }
}