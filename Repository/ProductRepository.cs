using CrudApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly TestAPIContext _dbContext;

        public ProductRepository(TestAPIContext context)
        {
            _dbContext = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;

        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.Id == productId);
            if(product != null)
            {
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }
    }
}
