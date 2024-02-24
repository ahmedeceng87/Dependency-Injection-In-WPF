namespace DataAccessLibrary
{
    public class DataAccess : IDataAccess
    {
        string IDataAccess.GetData()
        {
            return "Sample data from DataAccess class.";
        }
    }
}
