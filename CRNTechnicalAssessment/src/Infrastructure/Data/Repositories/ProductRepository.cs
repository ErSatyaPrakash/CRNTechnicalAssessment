using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<Product?> GetProductWithItemsAsync(int id)
        {
            return await _context.Products
                .Include(x => x.Items)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}