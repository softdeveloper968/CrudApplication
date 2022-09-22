using CrudApplication.Models;
using CrudApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> AddProduct(ProductViewModel product);
        Task<Product> UpdateProduct(ProductViewModel product);
        Task<bool> DeleteProduct(int productId);
    }
}
