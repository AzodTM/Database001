using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public class ViewTrains : Table
    {
        public static int MenuOfTrains(Model.Database DataBase)
        {
            TableSettings table = new TableSettings();
            table.columnPosition.Add(0);
            table.columnName.Add("#");
            table.columnPosition.Add(3);
            table.columnName.Add("TrainName");
            table.columnPosition.Add(15);
            table.columnName.Add("Rout");
            table.columnPosition.Add(30);
            table.columnName.Add("YearOfIssue");


            printHeadTible(table, new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);

            for (int i = 0; i < DataBase.trains.Count; i++)
            {
                Console.SetCursorPosition(table.columnPosition[0], table.FirstLineForData + i);
                Console.Write(i + 1);

                Console.SetCursorPosition(table.columnPosition[1], table.FirstLineForData + i);
                Console.Write(DataBase.trains[i].name);

                Console.SetCursorPosition(table.columnPosition[2], table.FirstLineForData + i);
                for (int j = 0; j < DataBase.routes.Count; j++)
                {
                    if (DataBase.trains[i].rout == DataBase.routes[j].id)
                    {
                        Console.WriteLine(DataBase.routes[j].name);
                    }
                }

                Console.SetCursorPosition(table.columnPosition[3], table.FirstLineForData + i);
                Console.Write(DataBase.trains[i].yearOfIssue);

                Console.WriteLine();

            }

            return Console.ReadKey().KeyChar - '0';
        }
    }
}