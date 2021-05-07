using System;
using DataBase001.Presentor;


namespace DataBase001.View
{
    public class CUI
    {
        public static int MainMenu()
        {
            PrintTitle(new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);
            Console.WriteLine("Press:");
            Console.WriteLine("1 - Cities");
            Console.WriteLine("2 - Routes");
            Console.WriteLine("3 - Trains");
            Console.WriteLine("0 - Create new test Data Base");
            return Console.ReadKey().KeyChar - '0';                  
        }
               
        public static int MenuOfCityes(Model.Database DataBase)
        {
            TableSettings col = new TableSettings();
            col.columnPosition.Add(0);
            col.columnPosition.Add(3);
            col.columnPosition.Add(15);
            col.columnName.Add("#");
            col.columnName.Add("CityName");
            col.columnName.Add("Population");

            printHeadTible(col, new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);  

            for (int i = 0; i < DataBase.citys.Count; i++)
            {
                Console.SetCursorPosition(col.columnPosition[0], col.FirstLineForData + i);
                Console.Write(i + 1);

                Console.SetCursorPosition(col.columnPosition[1], col.FirstLineForData + i);
                Console.Write(DataBase.citys[i].name);

                Console.SetCursorPosition(col.columnPosition[2], col.FirstLineForData + i);
                Console.Write(DataBase.citys[i].population);
                Console.WriteLine();

            }

            return Console.ReadKey().KeyChar - '0';
        }
        static void printHeadTible(TableSettings dataPosition, string title)
        {
            PrintTitle(title);

            for (int i = 0; i < dataPosition.columnName.Count; i++)
            {
                Console.SetCursorPosition(dataPosition.columnPosition[i], dataPosition.FirstLineForData - 1);
                Console.Write(dataPosition.columnName[i]);                
            }
            
        }

        static void Find()
        {

        }

        static void PrintTitle(string title)
        {
            Console.Clear();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(title);
        }
        public CUI()
        {
            //возможные стартовые настройки консоли
        }
    }
}
