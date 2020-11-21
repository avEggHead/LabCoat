using System;

namespace CSharpEight.Activities
{
    internal class ThrowsException : IExecute
    {
        public void Execute()
        {
            throw new ExecutionEngineException("hello");
        }
    }
}