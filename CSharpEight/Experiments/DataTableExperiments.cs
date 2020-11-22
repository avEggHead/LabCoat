using System.Data;
using System;

namespace Sandbox.Experiments
{
    internal class DataTableExperiments : IExperiment
    {
        public void Execute()
        {
            // create two tables
            DataTable table1 = new DataTable();
            //DataTable table2 = new DataTable();

            // Add the columns and the rows

            // create columns
            DataColumn t1column1 = new DataColumn("Column_One");
            DataColumn t1column2 = new DataColumn("Column_Two");
            DataColumn t1column3 = new DataColumn("Column_Three");

            DataColumn t2column1 = new DataColumn("Column_One");
            DataColumn t2column2 = new DataColumn("Column_Two");
            DataColumn t2column3 = new DataColumn("Column_Three");
            DataColumn column4 = new DataColumn("Column_Four");

            // add columns to table
            table1.Columns.AddRange(new DataColumn[] { t1column1, t1column2, t1column3, column4 });
            //table2.Columns.AddRange(new DataColumn[] { t2column1, t2column2, t2column3, column4 });

            // create rows
            var t1row1 = table1.NewRow();
            t1row1["Column_One"] = "1";
            t1row1["Column_Two"] = "value_two";
            t1row1["Column_Three"] = "value_three";
            table1.Rows.Add(t1row1);

            DataTable table2 = table1.Copy();

            var t2row1 = table2.NewRow();
            t2row1["Column_One"] = "1";
            t2row1["Column_Two"] = "IF YOU SEE THIS AFTER MERGE IT'S BAD";
            t2row1["Column_Three"] = "IF YOU SEE ME AFTER MERGE IT'S BAD";
            t2row1["Column_Four"] = "You should only see me :)";

            table2.Rows.Add(t2row1);
            table1.TableName = "Table 1";
            table2.TableName = "Table 2";
            table1.PrimaryKey = new DataColumn[] { table1.Columns["Column_One"] };
            table2.PrimaryKey = new DataColumn[] { table2.Columns["Column_One"] };

            // merge them
            Console.WriteLine("Columns in table 1 = " + table1.Columns.Count);
            Console.WriteLine("Columns in table 2 = " + table2.Columns.Count);

            this.PrintRowsOfTable(table1);
            this.PrintRowsOfTable(table2);

            table2.Merge(table1);

            this.PrintRowsOfTable(table1);
            this.PrintRowsOfTable(table2);
        }

        public string Identify()
        {
            return typeof(DataTableExperiments).Name;
        }

        private void PrintRowsOfTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Console.Write(table.TableName + ": ");
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write(row[column.ColumnName] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}