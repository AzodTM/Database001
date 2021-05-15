using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.Model
{
    public abstract class Entity
    {
        public Guid id { get; }
        public string name { set; get; }

        public Entity(string name)
        {
            id = Guid.NewGuid();
            this.name = name;
        }
            


    }
}
