namespace ClassLibrary1.Utilities
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}