using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase001.View
{
    public class TableSettings
    {
        public List<int> columnPosition;
        public List<string> columnName;
        public int FirstLineForData;

        public TableSettings()
        {
            columnPosition = new List<int>();
            columnName = new List<string>();
            FirstLineForData = 2;
        }
    }
}
