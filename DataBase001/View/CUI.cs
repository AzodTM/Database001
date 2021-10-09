using System;
using DataBase001.Presentor;


namespace DataBase001.View
{
    public class CUI
    {

        /// <summary>
        /// Отрисовка главного меню
        /// </summary>
        /// <returns></returns>
        public static int MainMenu()
        {
            PrintTitle(new System.Diagnostics.StackTrace(false).GetFrame(0).GetMethod().Name);
            Console.WriteLine("Press:");
            Console.WriteLine("1 - Show cities menu");
            Console.WriteLine("2 - Show routes menu");
            Console.WriteLine("3 - Show trains menu");
            Console.WriteLine("0 - Create new test Data Base");
            return Console.ReadKey().KeyChar - '0';                  
        }
        
        

        /// <summary>
        /// вызов отрисовки меню городов
        /// </summary>
        /// <param name="DataBase"></param>
        /// <returns></returns>
        public static int MenuOfCityes(Model.Database DataBase)
        {
            return ViewCityes.MenuOfCityes(DataBase);
        }



        /// <summary>
        /// вызов отрисовки меню маршрутов
        /// </summary>
        /// <param name="DataBase"></param>
        /// <returns></returns>
        public static int MenuOfRotues(Model.Database DataBase)
        {
            return ViewRoutes.MenuOfRoutes(DataBase);
        }



        /// <summary>
        /// вызов отрисовки меню поездов
        /// </summary>
        /// <param name="DataBase"></param>
        /// <returns></returns>
        public static int MenuOfTrains(Model.Database DataBase)
        {
            return ViewTrains.MenuOfTrains(DataBase);
        }



        /// <summary>
        /// Вызов поиска (в разработке)
        /// </summary>
        static void Find()
        {

        }



        /// <summary>
        /// Отрисовка названия меню по названию класса
        /// </summary>
        /// <param name="title"></param>
        static void PrintTitle(string title)
        {
            Console.Clear();
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(title);
        }



        /// <summary>
        /// Стартовые настройки консоли
        /// </summary>
        public CUI()
        {
            
        }
    }
}
