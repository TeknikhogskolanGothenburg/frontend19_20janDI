namespace BusinessLib.Utilities
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string data);
    }
}