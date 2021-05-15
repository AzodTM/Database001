using System;
using DataBase001.Presentor;


namespace DataBase001.View
{
    public class CUI
    {
        public static int MainMenu()
        {
            Title(new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);
            Console.WriteLine("Press:");
            Console.WriteLine("1 - Cities");
            Console.WriteLine("2 - Routes");
            Console.WriteLine("3 - Trains");
            Console.WriteLine("0 - Create new test Data Base");
            return Console.ReadKey().KeyChar - '0';                  
        }
               
        public static int MenuOfCityes(Model.Database DataBase)
        {
            Column col = new Column();
            
            int col1 = 0;
            int col2 = 3;
            int col3 = 15;
            int col4;
            int col5;            
            int FirstLineForData = 2;

            Title(new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);

            Console.SetCursorPosition(col1, FirstLineForData-1);
            Console.Write("#");
            Console.SetCursorPosition(col2, FirstLineForData - 1);
            Console.Write("CityName");
            Console.SetCursorPosition(col3, FirstLineForData - 1);
            Console.Write("Population");


            for (int i = 0; i < DataBase.citys.Count; i++)
            {
                Console.SetCursorPosition(col1, FirstLineForData + i);
                Console.Write(i + 1);

                Console.SetCursorPosition(col2, FirstLineForData + i);
                Console.Write(DataBase.citys[i].name);

                Console.SetCursorPosition(col3, FirstLineForData + i);
                Console.Write(DataBase.citys[i].population);
                Console.WriteLine();

            }

            return Console.ReadKey().KeyChar - '0';
        }
        static void printHeadTible(int col1,System.Diagnostics.StackFrame title,params string[] columnName)
        {

        }

        static void Find()
        {

        }

        static void Title(string title)
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
