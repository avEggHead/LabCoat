using System;
using System.Globalization;

namespace LabCoat.Experiments
{
    internal class DateTimeParsing : IExperiment
    {
        public void Experiment()
        {
            System.Console.WriteLine("Starting test");
            string dateString = "09-12-10 Monday at 8 pm cst".Replace(" ", "").Replace("Monday", "");
            //string dateString = "Monday";
            string formatStri = "yy-MM-dd'at'htt'cst'";
            DateTime dateValue;

            if (DateTime.TryParseExact(dateString, formatStri, CultureInfo.CurrentCulture, DateTimeStyles.None, out dateValue))
            {
                Console.WriteLine(dateValue.ToString());
                Console.WriteLine(dateValue.DayOfWeek.ToString());
            } else
            {
                Console.WriteLine("Something went wrong...");
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(DateTimeParsing);
        }
    }
}