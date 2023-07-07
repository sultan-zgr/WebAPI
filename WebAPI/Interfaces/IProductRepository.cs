using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product> GetByIdAsync(int id);
        public Task<Product> CreateAsync(Product product);
        public Task UpdateAsync(Product product);   
        public Task RemoveAsync(int id);
    }
}
