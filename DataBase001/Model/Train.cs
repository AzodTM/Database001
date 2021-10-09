using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.Model
{
    public class Train : Entity
    {
        public int yearOfIssue;

        public string name { set; get; }
        public Guid rout { get; }
        public Train(string name,Guid rout,int yearOfIssue = 1800)
        {
            this.yearOfIssue = yearOfIssue;
            this.rout = rout;
            this.name = name;
        }
    }
}
