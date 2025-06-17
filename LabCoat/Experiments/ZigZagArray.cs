using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCoat.Experiments
{
    internal class ZigZagArray : IExperiment
    {
        public void Experiment()
        {
            Console.WriteLine("Input: PANTSONFIRE 3");
            Console.WriteLine("Expected Output: PSIATOFRNNE");
            Console.WriteLine(PrintZigZag("PANTSONFIRE", 3));

            Console.WriteLine("Input: PAYPALISHIRING 3");
            Console.WriteLine("Expected: PAHNAPLSIIGRYIR");
            Console.WriteLine(PrintZigZag("PAYPALISHIRING", 3));

            Console.WriteLine("Input: PAYPALISHIRING 4");
            Console.WriteLine("Expected: PINALSIGYAHRPI");
            Console.WriteLine(PrintZigZag("PAYPALISHIRING", 4));

            Console.WriteLine("Input: PAYPALISHIRING 1");
            Console.WriteLine("Expected: PAYPALISHIRING");
            Console.WriteLine(PrintZigZag("PAYPALISHIRING", 1));
        }

        private string PrintZigZag(string s, int numRows)
        {
            if (numRows == 1) return s;
            // create list of string for each row
            List<Row> rows = new List<Row>();
            string result = "";

            for(int i = 1; i <= numRows; i++)
            {
                Row row = new Row(i);
                rows.Add(row);
            }

            int currentRow = 1;
            bool isDescending = true;
            foreach(var letter in s)
            {
                Row row = rows.Where(r => r.RowNumber == currentRow).FirstOrDefault();
                row.RowString += letter.ToString();
                if (isDescending)
                {
                    if (row.RowNumber < numRows)
                    {
                        currentRow++;
                    }
                    else
                    {
                        currentRow = numRows - 1;
                        isDescending = false; // start climbing
                    }
                }
                else // is climbing
                {
                    if (row.RowNumber > 1)
                    {
                        currentRow--;
                    }
                    else
                    {
                        currentRow = 2;
                        isDescending = true;
                    }
                }
            }

            // build the final string
            foreach (var row in rows)
            {
                result += row.RowString;
            }

            return result;
        }

        public string IdentifyExperiment()
        {
            return "ZigZagArray";
        }

        private class Row
        {
            public int RowNumber;
            public string RowString;

            public Row(int rowNumber)
            {
                this.RowNumber = rowNumber;
            }
        }
    }
}