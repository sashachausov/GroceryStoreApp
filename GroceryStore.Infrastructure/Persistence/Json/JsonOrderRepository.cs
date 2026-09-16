using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Interfaces;
using GroceryStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GroceryStore.Infrastructure.Persistence.Json
{
    public class JsonOrderRepository : IOrderRepository
    {
        private readonly string _filePath = "orders.json";
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
        };

        public async Task<List<Order>> GetAllAsync()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return new List<Order>();

                var json = await File.ReadAllTextAsync(_filePath);
                return JsonSerializer.Deserialize<List<Order>>(json) ?? new List<Order>();
            }
            catch
            {
                throw new AppException("Failed to read order data.");
            }
        }

        public async Task<Order?> GetByIdAsync(Guid id) => (await GetAllAsync()).FirstOrDefault(o => o.Id == id);

        public async Task AddAsync(Order order)
        {
            await _lock.WaitAsync();

            try
            {
                var orders = await GetAllAsync();
                orders.Add(order);
                await SaveAsync(orders);
            }
            finally
            {
                _lock?.Release();
            }
        }        

        public async Task UpdateAsync(Order order)
        {
            await _lock.WaitAsync();

            try
            {
                var orders = await GetAllAsync();
                var index = orders.FindIndex(o => o.Id == order.Id);
                if (index >= 0)
                {
                    orders[index] = order;
                    await SaveAsync(orders);
                }
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task SaveAsync(List<Order> orders)
        {
            try
            {
                var json = JsonSerializer.Serialize(orders, _options);
                await File.WriteAllTextAsync(_filePath, json);
            }
            catch (Exception ex)
            {
                throw new AppException($"Failed to save order data. {ex.Message}");
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            await _lock.WaitAsync();

            try
            {
                var orders = await GetAllAsync();
                orders.RemoveAll(o => o.Id == id);
                await SaveAsync(orders);
            }
            finally
            {
                _lock.Release();
            }
        }
    }
}
