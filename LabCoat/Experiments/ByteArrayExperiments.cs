namespace Sandbox.Experiments
{
    using System;
    using System.Text;

    internal class ByteArrayExperiments : IExperiment
    {
        public void Experiment()
        {
            // Can I convert an integer to a byte[]?  Not directly, but you could parse it as a string and parse it back to an int.

            int number = 55;

            byte[] numberAsByteArray = Encoding.ASCII.GetBytes(number.ToString());

            string numberAsString = Encoding.ASCII.GetString(numberAsByteArray);

            System.Console.WriteLine(Int32.Parse(numberAsString));
        }

        public string IdentifyExperiment()
        {
            return nameof(ByteArrayExperiments);
        }
    }
}