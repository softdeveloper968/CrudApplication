using CrudApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}
