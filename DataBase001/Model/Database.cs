using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.Model
{
    
    public class Database
    {
        public List<City> cities { private set; get; }
        public List<Route> routes { private set; get; }
        public List<Train> trains { private set; get; }

        public Database()
        {
            citys = new List<City>();
            routes = new List<Route>();
            trains = new List<Train>();
        }
        
    }
}
