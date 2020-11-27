namespace LabCoat.Experiments
{
    internal class ExperimentWithSomethingNew : IExperiment
    {
        public void Experiment()
        {
            System.Console.WriteLine("I am experimenting with complicated data structures.");
        }

        public string IdentifyExperiment()
        {
            return nameof(ExperimentWithSomethingNew);
        }
    }
}