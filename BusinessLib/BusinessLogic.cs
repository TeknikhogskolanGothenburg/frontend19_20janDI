using BusinessLib.Utilities;
using System;

namespace BusinessLib
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting process of data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Data");
            _logger.Log("Finished processing data");
        }
    }
}
