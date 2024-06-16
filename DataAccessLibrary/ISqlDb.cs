
namespace DataAccessLibrary
{
    public interface ISqlDb
    {
        string myConnectionString { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}