namespace Sandbox.Experiments
{
    using System.Security;
    using System.Security.Cryptography;
    using System.Text;

    internal class CryptographyHowItWorks : IExperiment
    {
        public void Experiment()
        {
            DataProtectionScope scope = DataProtectionScope.CurrentUser;

            string messageInTheClear = "This is an important message";
            byte[] messageAsByteArray = Encoding.ASCII.GetBytes(messageInTheClear);
            System.Console.WriteLine("Message in the clear" + messageInTheClear);
            this.PrintByteArrayContents(messageAsByteArray, "Message as byte array");
            byte[] safeMessage = ProtectedData.Protect(messageAsByteArray, null, scope);
            this.PrintByteArrayContents(safeMessage, "Safe Message");
            byte[] decryptedMessage = ProtectedData.Unprotect(safeMessage, null, scope);
            this.PrintByteArrayContents(decryptedMessage, "Decrypted Safe Message");
            string decryptedStringMessage = Encoding.ASCII.GetString(decryptedMessage);
            System.Console.WriteLine(decryptedStringMessage);

            byte[] original = { 1, 2, 3, 4, 5 };
            this.PrintByteArrayContents(original, "Original Before Encryption");

            byte[] encrypted = ProtectedData.Protect(original, null, scope);
            this.PrintByteArrayContents(original, "Original After Encryption");
            this.PrintByteArrayContents(encrypted, "Encrypted After Encryption");

            byte[] decrypted = ProtectedData.Unprotect(encrypted, null, scope);
            this.PrintByteArrayContents(encrypted, "Encrypted After Decryption");
            this.PrintByteArrayContents(decrypted, "Decrypted After Decryption");
        }

        public void PrintByteArrayContents(byte[] byteArray, string label)
        {
            System.Console.WriteLine(label);
            foreach (var thing in byteArray)
            {
                System.Console.Write(thing + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        public string IdentifyExperiment()
        {
            return nameof(CryptographyHowItWorks);
        }
    }
}