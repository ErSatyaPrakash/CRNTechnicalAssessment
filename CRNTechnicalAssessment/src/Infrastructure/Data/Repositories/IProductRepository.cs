using Domain.Entities;

namespace Infrastructure.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product?> GetProductWithItemsAsync(int id);
    }
}