using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLib.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }


        public void SaveData(string data)
        {
            Console.WriteLine($"Saving { data }");
        }
    }
}
