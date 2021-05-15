using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public class Column
    {
        public List<int> columnPosition;
        public List<string> columnName;
        
        public Column()
        {
            columnPosition = new List<int>();
            columnName = new List<string>();
        }
    }
}
