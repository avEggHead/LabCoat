using System.Text;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace LabCoat.Experiments
{
    internal class WorkingWithJSON : IExperiment
    {
        public void Experiment()
        {
            string person = @"{
            ""FirstName"":""Sara"",
            ""LastName"":""Wells"",
            ""Age"":35,
            ""Friends"":[""Dylan"",""Ian""]
              }";

            byte[] data = Encoding.UTF8.GetBytes(person);
            Utf8JsonReader reader = new Utf8JsonReader(data);

            while (reader.Read())
            {
                //System.Console.WriteLine(reader.TokenType);
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    System.Console.WriteLine(reader.GetString());
                }
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(WorkingWithJSON);
        }
    }
}