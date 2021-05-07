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
            return ViewCityes.MenuOfCityes(DataBase);
        }
        public static int MenuOfRotues(Model.Database DataBase)
        {
            return ViewRoutes.MenuOfRoutes(DataBase);
        }
        public static int MenuOfTrains(Model.Database DataBase)
        {
            return ViewTrains.MenuOfTrains(DataBase);
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
