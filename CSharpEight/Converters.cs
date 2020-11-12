using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace CSharpEight
{
    public class Converters : IExecute
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
    }
}