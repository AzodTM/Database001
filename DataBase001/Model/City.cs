using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.Model
{
    public class City : Entity
    {
        public int population;
        public City(string name,int population = 1000 ) : base(name)
        {
            this.population = population;
        }

    }
}
