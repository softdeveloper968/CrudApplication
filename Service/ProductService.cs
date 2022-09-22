using CrudApplication.Models;
using CrudApplication.Repository;
using CrudApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> AddProduct(ProductViewModel product)
        {
            return await _productRepository.AddProduct(new Product
            {
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription
            });
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            return await _productRepository.DeleteProduct(productId);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<Product> UpdateProduct(ProductViewModel product)
        {
            return await _productRepository.UpdateProduct(new Product
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription
            });
        }
    }
}
