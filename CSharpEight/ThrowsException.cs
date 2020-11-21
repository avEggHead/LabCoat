using System;

namespace CSharpEight
{
    internal class ThrowsException : IExecute
    {
        public void Execute()
        {
            throw new ExecutionEngineException("hello");
        }
    }
}