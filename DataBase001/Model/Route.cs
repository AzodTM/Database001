using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.Model
{
    public class Route : Entity
    {
        public List<Guid> RoutOfSity { set; get; }

        public string name { set; get; }

        public Route(string name,List<Guid> RoutOfSity)
        {
            this.RoutOfSity = RoutOfSity;

            this.name = name;
        }
    }
}
