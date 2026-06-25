using GroceryStore.Application.Interfaces;
using GroceryStore.Application.Other;
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

        public async Task UpdateAsync(Guid id, string name, string sku, decimal price, ProductUnit unit)
        {
            var product = await _repository.GetByIdAsync(id);

            if (product == null)
                throw new Exception("Product not found");

            product.SetName(name);
            product.SetSku(sku);
            product.SetPrice(price);

            await _repository.UpdateAsync(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<Product>> QueryAsync(ProductQuery query)
        {
            var products = await _repository.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(query.Name))
            {
                products = products.Where(p => p.Name.Contains(query.Name, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (query.MaxPrice.HasValue && query.MaxPrice > 0)
            {
                products = products.Where(p => p.Price <= query.MaxPrice.Value).ToList();
            }

            switch (query.SortOption)
            {
                case ProductSortOption.Alphabetical:
                    return products.OrderBy(p => p.Name).ToList();
                case ProductSortOption.PriceAscending:
                    return products.OrderBy(p => p.Price).ToList();
                case ProductSortOption.PriceDescending:
                    return products.OrderByDescending(p => p.Price).ToList();
                default:
                    break;
            }

            return products;
        }
    }
}
