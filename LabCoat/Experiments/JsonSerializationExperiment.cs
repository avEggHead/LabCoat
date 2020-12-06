namespace LabCoat.Experiments
{
    using System.Text.Json;

    internal class JsonSerializationExperiment : IExperiment
    {
        public void Experiment()
        {
            var p = new Person { Name = "Clinton" };
            string json = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            System.Console.WriteLine(json);
            var holder = new AttributeHolder { Number = 11, Label = "This", Power = "Fire" };
            string thing = JsonSerializer.Serialize<AttributeHolder>(holder, new JsonSerializerOptions { WriteIndented = true });
            System.Console.WriteLine(thing);
            var deser = JsonSerializer.Deserialize<AttributeHolder>(thing);
            System.Console.WriteLine(deser.GetType());
        }

        public class Person
        {
            public string Name { get; set; }
        }

        public class AttributeHolder
        {
            public int Number { get; set; }
            public string Label { get; set; }
            public string Power { get; set; }
        }

        public string IdentifyExperiment()
        {
            return nameof(JsonSerializationExperiment);
        }
    }
}