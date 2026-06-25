using GroceryStore.Application.Interfaces;
using GroceryStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GroceryStore.Infrastructure.Json
{
    public class JsonProductRepository : IProductRepository
    {
        private readonly string _filePath = "product.json";
        
        public async Task<List<Product>> GetAllAsync()
        {
            if (!File.Exists(_filePath))
                return new List<Product>();

            var json = await File.ReadAllTextAsync(_filePath);

            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public async Task AddAsync(Product product)
        {
            var products = await GetAllAsync();
            products.Add(product);
            await SaveAsync(products);
        }

        public async Task UpdateAsync(Product product)
        {
            var products = await GetAllAsync();
            var index = products.FindIndex(p => p.Id == product.Id);

            if (index >= 0)
            {
                products[index] = product;
                await SaveAsync(products);
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var products = await GetAllAsync();
            products.RemoveAll(p => p.Id == id);
            await SaveAsync(products);
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            var products = await GetAllAsync();
            return products.FirstOrDefault(p => p.Id == id);
        }

        private async Task SaveAsync(List<Product> products)
        {
            var json = JsonSerializer.Serialize(products, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            await File.WriteAllTextAsync(_filePath, json);
        }
    }
}
