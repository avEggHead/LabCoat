namespace LabCoat
{
    public interface IExperiment
    {
        public void Experiment();

        /// <summary>
        /// In your implementation use the syntax in the returns tag.
        /// </summary>
        /// <returns>   return typeof(put the name of the class here).Name;    </returns>
        public string IdentifyExperiment();
    }
}