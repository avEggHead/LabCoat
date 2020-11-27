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
            byte[] hash2;
            string representsData = "I represent a large amount of data";
            byte[] bytes = Encoding.ASCII.GetBytes(representsData);
            this.PrintObjectArray<byte>(bytes, "This is the byte array of the sentence string: ");
            hash = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(representsData));
            this.PrintObjectArray<byte>(hash, "This is the hash code of the byte array: ");
            hash2 = SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(representsData));
            this.PrintObjectArray<byte>(hash2, "This is the hash code of the byte array: ");

            Console.Write("hash1 = hash2 ? : ");
            Console.WriteLine(this.CompareByteArrays(hash, hash2));

            //change one element in the hash
            hash[5] = new byte();
            this.PrintObjectArray<byte>(hash, "Hash after alteration.");
            Console.Write("hash1 = hash2 ? : ");
            Console.WriteLine(this.CompareByteArrays(hash, hash2));
        }

        private bool CompareByteArrays(byte[] hash, byte[] hash2)
        {
            var indexTracker = 0;
            foreach (byte item in hash)
            {
                if (item != hash2[indexTracker])
                {
                    return false;
                }
                indexTracker++;
            }
            return true;
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