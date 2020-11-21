using System;
using System.ComponentModel;
using System.Drawing;

namespace Sandbox.Activities
{
    public class Converters : IExperiment
    {
        public void Execute()
        {
            double number = 3.9;
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            Color color = (Color)colorConverter.ConvertFromString("Beige");
            Console.WriteLine(color);
        }

        public string Identify()
        {
            return typeof(Converters).Name;
        }
    }
}