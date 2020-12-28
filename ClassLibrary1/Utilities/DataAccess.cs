using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Utilities
{
    class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            _logger.Log("Loading Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
            _logger.Log("Saving Data");
        }
    }
}
