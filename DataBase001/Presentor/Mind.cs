using System;
using DataBase001.Model;
using DataBase001.View;
using System.Collections.Generic;


namespace DataBase001.Presentor
{
    
    public class Mind
    {
        Database myBase;

        public void Enter()
        {
            while (true)
            {
                var MainMenuChoose = CUI.MainMenu();

                switch(MainMenuChoose)
                {
                    case 1:
                        CUI.MenuOfCityes(myBase);                   
                        break;
                    case 2:
                        CUI.MenuOfRotues(myBase);
                        break;
                    case 3:
                        CUI.MenuOfTrains(myBase);
                        break;
                    case 0:                        
                        myBase = BaseTest();
                        Console.Clear();
                        Console.WriteLine("Test base loaded");
                        Console.WriteLine("Press any key to contine");
                        Console.ReadKey();
                        break;
                }
            }
            

            

        }

         Database BaseTest()
        {
            Database db = new Database();

            db.citys.Add(new City("Moscow", 10000000));
            db.citys.Add(new City("Paris", 15000000));
            db.citys.Add(new City("Perm", 1000000));
            db.citys.Add(new City("Rome", 20000000));
            db.citys.Add(new City("London", 35000000));


            NewRoute("route01", db, "Moscow", "Perm");
            NewRoute("route02", db, "Moscow", "Paris", "Rome");
            NewRoute("route03", db, "Perm", "Moscow", "London");

            db.trains.Add(new Train("train01", db.routes[0].id,1864));
            db.trains.Add(new Train("train02", db.routes[0].id,1921));
            db.trains.Add(new Train("train03", db.routes[1].id,1878));
            db.trains.Add(new Train("train04", db.routes[1].id,1895));
            db.trains.Add(new Train("train05", db.routes[2].id,1908));


            return db;
        }

        static void NewRoute(string name, Database myBase, params string[] nameOfCityes)
        {
            var cityGuids = new List<Guid>();


            foreach (string city in nameOfCityes)
            {
                for (int i = 0; i < myBase.citys.Count; i++)
                {
                    if (city == myBase.citys[i].name)
                    {
                        cityGuids.Add(myBase.citys[i].id);
                    }
                }
            }

            myBase.routes.Add(new Route(name, cityGuids));

        }
        //public static void WriteBase(Model.Database database)
        //{
        //    var writer = new System.Xml.Serialization.XmlSerializer(typeof(Model.Database));
        //    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//myBase.xml";
        //    var file = System.IO.File.Create(path);

        //    writer.Serialize(file, database);
        //    file.Close();
        //}
    }
}
