using BidIt.Shared;

namespace BidIt.Server.Repositories
{
    public interface IItemsRepository
    {
        Task<Book?> GetAsync(int auctionId, int itemId);
        Task<IReadOnlyList<Book>> GetManyAsync(int auctionId);
        Task CreateAsync(Book item);
        Task UpdateAsync(Book item);
        Task DeleteAsync(Book item);

    }
}
