using GroceryStore.Application.Interfaces;
using GroceryStore.Domain.Entities;
using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<Product>> GetAllAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task CreateAsync(string name, string sku, decimal price, ProductUnit unit)
        {
            var product = new Product(name, sku, price, unit);
            await _repository.AddAsync(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
