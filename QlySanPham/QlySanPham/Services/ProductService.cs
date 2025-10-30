using QlySanPham.Models;
using QlySanPham.Repositories.Interfaces;
using QlySanPham.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QlySanPham.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(Product product)
        {
            // Add business validation here if needed
            await _repo.AddAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product != null)
            {
                await _repo.DeleteAsync(product);
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Product product)
        {
            await _repo.UpdateAsync(product);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _repo.ExistsAsync(id);
        }
    }
}