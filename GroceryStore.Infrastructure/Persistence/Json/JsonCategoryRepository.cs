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
    public class JsonCategoryRepository : ICategoryRepository
    {
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "categories.json");
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        private static readonly JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        
        public async Task<List<Category>> GetAllAsync()
        {
            await _lock.WaitAsync();

            try
            {
                if (!File.Exists(_filePath))
                    return new List<Category>();

                var json = await File.ReadAllTextAsync(_filePath);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<Category>();

                return JsonSerializer.Deserialize<List<Category>>(json, serializerOptions) ?? new List<Category>();
            }
            catch (JsonException)
            {
                throw new AppException("Category data file is corrupted.");
            }
            catch (IOException)
            {
                throw new AppException("Failed to read category data file.");
            }
            finally 
            { 
                _lock.Release(); 
            }
        }

        public async Task<Category?> GetByIdAsync(Guid id)
        {
            var categories = await GetAllAsync();
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public async Task AddAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            await _lock.WaitAsync();

            try
            {
                var categories = await LoadInternalAsync();
                categories.Add(category);
                await SaveInternalAsync(categories);
            }
            finally
            {
                _lock.Release();
            }            
        }

        public async Task UpdateAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            await _lock.WaitAsync();

            try
            {
                var categories = await LoadInternalAsync();
                var index = categories.FindIndex(c => c.Id == category.Id);

                if (index < 0)
                    throw new AppException("Category could not be updated because it was not found.");

                categories[index] = category;
                await SaveInternalAsync(categories);
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
                var categories = await LoadInternalAsync();

                var removedCount = categories.RemoveAll(c => c.Id == id);

                if (removedCount == 0)
                    throw new AppException("Categories could not be deleted because it was not found.");

                await SaveInternalAsync(categories);
            }
            finally
            {
                _lock.Release();
            }
        }

        private async Task<List<Category>> LoadInternalAsync()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return new List<Category>();

                var json = await File.ReadAllTextAsync(_filePath);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<Category>();

                return JsonSerializer.Deserialize<List<Category>>(json, serializerOptions) ?? new List<Category>();
            }
            catch (JsonException)
            {
                throw new AppException("Category data file is corrupted.");
            }
            catch (IOException)
            {
                throw new AppException("Failed to read category data file.");
            }
        }

        private async Task SaveInternalAsync(List<Category> categories)
        {
            try
            {
                var json = JsonSerializer.Serialize(categories, serializerOptions);
                await File.WriteAllTextAsync(_filePath, json);
            }
            catch (IOException)
            {
                throw new AppException("Failed to save category data file.");
            }
        }
    }
}
