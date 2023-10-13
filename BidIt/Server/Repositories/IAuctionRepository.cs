using BidIt.Shared;

namespace BidIt.Server.Repositories
{
    public interface IAuctionRepository
    {
        Task<Auction?> GetAsync(int auctionId);
        Task<IReadOnlyList<Auction>> GetManyAsync();
        Task CreateAsync(Auction auction);
        Task UpdateAsync(Auction auction);
        Task DeleteAsync(Auction auction);
    }
}
