using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public class ViewCityes : Table
    {
        public static int MenuOfCityes(Model.Database DataBase)
        {
            TableSettings table = new TableSettings();
            table.columnPosition.Add(0);
            table.columnName.Add("#");
            table.columnPosition.Add(3);
            table.columnName.Add("CityName");
            table.columnPosition.Add(15);  
            table.columnName.Add("Population");
                        

            printHeadTible(table, new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);

            for (int i = 0; i < DataBase.citys.Count; i++)
            {
                Console.SetCursorPosition(table.columnPosition[0], table.FirstLineForData + i);
                Console.Write(i + 1);

                Console.SetCursorPosition(table.columnPosition[1], table.FirstLineForData + i);
                Console.Write(DataBase.citys[i].name);

                Console.SetCursorPosition(table.columnPosition[2], table.FirstLineForData + i);
                Console.Write(DataBase.citys[i].population);
                Console.WriteLine();

            }

            return Console.ReadKey().KeyChar - '0';
        }
    }
}
