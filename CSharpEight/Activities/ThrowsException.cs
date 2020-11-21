using System;

namespace Sandbox.Activities
{
    internal class ThrowsException : IExperiment
    {
        public void Execute()
        {
            throw new FieldAccessException("hello");
        }

        public string Identify()
        {
            return typeof(ThrowsException).Name;
        }
    }
}