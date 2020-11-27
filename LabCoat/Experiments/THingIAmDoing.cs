namespace LabCoat.Experiments
{
    internal class THingIAmDoing : IExperiment
    {
        public void Experiment()
        {
            System.Console.WriteLine("i AM DOING NEW STUFF");
        }

        public string IdentifyExperiment()
        {
            return nameof(THingIAmDoing);
        }
    }
}