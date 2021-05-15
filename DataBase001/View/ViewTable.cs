using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public abstract class ViewTable
    {
        protected static void printHeadTible(TableSettings dataPosition, string title)
        {
            PrintTitle(title);

            for (int i = 0; i < dataPosition.columnName.Count; i++)
            {
                Console.SetCursorPosition(dataPosition.columnPosition[i], dataPosition.FirstLineForData - 1);
                Console.Write(dataPosition.columnName[i]);
            }

        }
        static void PrintTitle(string title)
        {
            Console.Clear();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(title);
        }
    }
}
