namespace BidIt.Server.Services
{
    public  interface IDataBaseOperations
    {
        Task ExecuteAsync(string query);

        Task<List<T>> ReadListAsync<T>(string query);

        Task<T?> ReadItemAsync<T>(string query);
    }
}
