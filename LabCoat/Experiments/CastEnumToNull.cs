namespace LabCoat.Experiments
{
    internal class CastEnumToNull : IExperiment
    {
        public void Experiment()
        {
            //var thing = (TestEnum);

        }

        public string IdentifyExperiment()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum TestEnum
    {
        value,
        value1,
        value2
    }
}