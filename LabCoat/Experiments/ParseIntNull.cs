using System;

namespace LabCoat.Experiments
{
    internal class ParseIntNull : IExperiment
    {
        public void Experiment()
        {
            try
            {
                int.Parse(null);
            }
            catch(Exception ex)
            {
                Console.WriteLine("You hit the catch block! " + ex.GetType() + " " + ex.Message);
            }
        }

        public string IdentifyExperiment()
        {
            return "ParseINtNull";
        }
    }
}