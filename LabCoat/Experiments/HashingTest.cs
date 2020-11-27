namespace Sandbox.Experiments
{
    using System.Security.Cryptography;
    using System.Text;
    using System;

    internal class HashingTest : IExperiment
    {
        public void Experiment()
        {
            byte[] hash;
            string representsData = "I represent a large amount of data";
            byte[] bytes = Encoding.ASCII.GetBytes(representsData);
            this.PrintObjectArray<byte>(bytes, "This is the byte array of the sentence string: ");
            hash = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(representsData));
            this.PrintObjectArray<byte>(hash, "This is the hash code of the byte array: ");
        }

        public void PrintObjectArray<T>(T[] objectArray, string message)
        {
            Console.WriteLine(message);
            foreach (var thing in objectArray)
            {
                Console.Write(thing + ", ");
            }
            Console.WriteLine();
        }

        public string IdentifyExperiment()
        {
            return nameof(HashingTest);
        }
    }
}