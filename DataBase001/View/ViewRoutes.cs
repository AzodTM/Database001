using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public class ViewRoutes : ViewTable
    {
        public static int MenuOfRoutes(Model.Database DataBase)
        {
            TableSettings table = new TableSettings();
            table.columnPosition.Add(0);
            table.columnName.Add("#");
            table.columnPosition.Add(3);
            table.columnName.Add("RoutName");
            table.columnPosition.Add(15);
            table.columnName.Add("Rout");


            printHeadTible(table, new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);

            for (int i = 0; i < DataBase.routes.Count; i++)
            {
                Console.SetCursorPosition(table.columnPosition[0], table.FirstLineForData + i);
                Console.Write(i + 1);

                Console.SetCursorPosition(table.columnPosition[1], table.FirstLineForData + i);
                Console.Write(DataBase.routes[i].name);

                Console.SetCursorPosition(table.columnPosition[2], table.FirstLineForData + i);
                for (int j = 0; j < DataBase.routes[i].RoutOfSity.Count; j++)
                {
                    List<String> sityNameRoute = new List<string>();
                    for (int n = 0; n < DataBase.citys.Count; n++)
                    {
                        if(DataBase.routes[i].RoutOfSity[j] == DataBase.citys[n].id)
                        {

                            sityNameRoute.Add(DataBase.citys[n].name);
                            Console.Write(DataBase.citys[n].name + "->");
                        }
                    }
                }
                Console.WriteLine();

            }

            return Console.ReadKey().KeyChar - '0';
        }
    }
}
