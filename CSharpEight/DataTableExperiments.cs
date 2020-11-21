using System.Data;
using System;

namespace CSharpEight
{
    internal class DataTableExperiments : IExecute
    {
        public void Execute()
        {
            // create two tables
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();

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
            table1.Columns.AddRange(new DataColumn[] { t1column1, t1column2, t1column3 });
            table2.Columns.AddRange(new DataColumn[] { t2column1, t2column2, t2column3, column4 });

            // create rows
            var row1 = table1.NewRow();
            row1["Column_One"] = "1";
            row1["Column_Two"] = "value_two";
            row1["Column_Three"] = "value_three";

            var row2 = table2.NewRow();
            row2["Column_One"] = "1";
            row2["Column_Two"] = "THIS IS ALSO BAD";
            row2["Column_Three"] = "THIS IS BAD";
            row2["Column_Four"] = "You should only see me :)";

            table1.Rows.Add(row1);
            table2.Rows.Add(row2);
            table1.PrimaryKey = new DataColumn[] { table1.Columns["Column_One"] };
            table2.PrimaryKey = new DataColumn[] { table2.Columns["Column_One"] };
            // merge them

            // cw the results
            Console.WriteLine("Columns in table 1 = " + table1.Columns.Count);
            Console.WriteLine("Columns in table 2 = " + table2.Columns.Count);

            this.PrintRowsOfTable(table1);
            this.PrintRowsOfTable(table2);

            // merge the two
            table2.Merge(table1);

            this.PrintRowsOfTable(table1);
            this.PrintRowsOfTable(table2);
        }

        private void PrintRowsOfTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write(row[column.ColumnName] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}