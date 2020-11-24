using System;
using System.ComponentModel;
using System.Drawing;

namespace Sandbox.Experiments
{
    public class Converters : IExperiment
    {
        public void Experiment()
        {
            double number = 3.9;
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            Color color = (Color)colorConverter.ConvertFromString("Beige");
            Console.WriteLine(color);
        }

        public string IdentifyExperiment()
        {
            return typeof(Converters).Name;
        }
    }
}