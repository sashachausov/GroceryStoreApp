using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Interfaces;
using GroceryStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace GroceryStore.Infrastructure.Persistence.Json
{
    public class JsonProductRepository : IProductRepository
    {
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.json");
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        private static readonly JsonSerializerOptions SerializerOptions = new()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        
        public async Task<List<Product>> GetAllAsync()
        {
            await _lock.WaitAsync();

            try
            {
                return await LoadInternalAsync();
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task AddAsync(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            await _lock.WaitAsync();

            try
            {
                var products = await LoadInternalAsync();
                products.Add(product);
                await SaveInternalAsync(products);
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task UpdateAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            await _lock.WaitAsync();

            try
            {
                var products = await LoadInternalAsync();
                var index = products.FindIndex(p => p.Id == product.Id);

                if (index < 0)
                    throw new AppException("Product could not be updated because it was not found.");
                
                products[index] = product;
                await SaveInternalAsync(products);
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            await _lock.WaitAsync();

            try
            {
                var products = await LoadInternalAsync();
                var removeCount = products.RemoveAll(p => p.Id == id);
                
                if (removeCount == 0)
                    throw new AppException("Product could not be deleted because it was not found.");
                await SaveInternalAsync(products);
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            var products = await GetAllAsync();
            return products.FirstOrDefault(p => p.Id == id);
        }

        private async Task<List<Product>> LoadInternalAsync()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return new List<Product>();

                var json = await File.ReadAllTextAsync(_filePath);
                if (string.IsNullOrWhiteSpace(json))
                    return new List<Product>();

                return JsonSerializer.Deserialize<List<Product>>(json, SerializerOptions) ?? new List<Product>();
            }
            catch (JsonException)
            {
                throw new AppException("Product data file is corrupted.");
            }
            catch (IOException)
            {
                throw new AppException("Failed to read product data file.");
            }
        }

        private async Task SaveInternalAsync(List<Product> products)
        {
            try
            {
                var json = JsonSerializer.Serialize(products, SerializerOptions);
                await File.WriteAllTextAsync(_filePath, json);
            }
            catch (IOException)
            {
                throw new AppException("Failed to save product data file.");
            }
        }
    }
}
