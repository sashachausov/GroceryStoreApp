using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Interfaces;
using GroceryStore.Application.Mappers.Product;
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
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
        }

        public async Task<List<ProductListItemDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            var categories = await _categoryRepository.GetAllAsync();

            return products.Where(p => p.IsActive).Select(p => MapToListItemDto(p, categories)).ToList();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
                throw new NotFoundException("Product not found.");
            return product;
        }

        public async Task CreateAsync(string name, string sku, decimal price, ProductUnit unit, Guid categoryId)
        {
            await EnsureCategoryExistsAsync(categoryId);

            var product = new Product(name, sku, price, unit, categoryId);
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateAsync(Guid id, string name, string sku, decimal price, ProductUnit unit, Guid categoryId)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
                throw new NotFoundException("Product not found");

            try
            {
                product.SetName(name);
                product.SetSku(sku);
                product.SetPrice(price);
                product.SetUnit(unit);
                product.SetCategory(categoryId);
            }
            catch (ValidationException ex)
            {
                throw new ValidationException(ex.Message);
            }

            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
                throw new NotFoundException("Product not found.");
            product.Deactivate();
            await _productRepository.UpdateAsync(product);
        }

        public async Task<List<ProductListItemDto>> QueryAsync(ProductQuery query)
        {
            var products = await _productRepository.GetAllAsync();
            var categories = await _categoryRepository.GetAllAsync();

            products = products.Where(p => p.IsActive).ToList();
                
            if (!string.IsNullOrWhiteSpace(query.Name))
            {
                products = products.Where(p => p.Name.Contains(query.Name, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (query.MaxPrice.HasValue && query.MaxPrice > 0)
            {
                products = products.Where(p => p.Price <= query.MaxPrice.Value).ToList();
            }

            if (query.CategoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == query.CategoryId.Value).ToList();
            }

            products = query.SortOption switch
            {
                ProductSortOption.Alphabetical =>
                    products.OrderBy(p => p.Name).ToList(),

                ProductSortOption.PriceAscending =>
                    products.OrderBy(p => p.Price).ToList(),

                ProductSortOption.PriceDescending =>
                    products.OrderByDescending(p => p.Price).ToList(),

                _ => products
            };

            return products.Select(p => MapToListItemDto(p, categories)).ToList();


            //switch (query.SortOption)
            //{
            //    case ProductSortOption.Alphabetical:
            //        return products.OrderBy(p => p.Name).ToList();
            //    case ProductSortOption.PriceAscending:
            //        return products.OrderBy(p => p.Price).ToList();
            //    case ProductSortOption.PriceDescending:
            //        return products.OrderByDescending(p => p.Price).ToList();
            //    default:
            //        return products;
            //}
        }

        private static ProductListItemDto MapToListItemDto(Product product, List<Category> categories)
        {
            var category = categories.FirstOrDefault(c => c.Id == product.CategoryId);
            return new ProductListItemDto
            {
                Id = product.Id,
                Name = product.Name,
                Sku = product.Sku,
                Price = product.Price,
                Unit = product.Unit,
                UnitDisplayName = GetUnitDisplayName(product.Unit),
                CategoryId = product.CategoryId,
                CategoryName = category?.Name ?? "Без категории",
                IsActive = product.IsActive,
            };
        }

        private async Task EnsureCategoryExistsAsync(Guid categoryId)
        {
            if (categoryId == Guid.Empty)
                throw new ValidationException("Selected category does not exist.");
            
            var category = await _categoryRepository.GetByIdAsync(categoryId);
            
            if (category == null || !category.IsActive)
                throw new ValidationException("Selected category does not exist.");
        }

        private static string GetUnitDisplayName(ProductUnit unit)
        {
            switch (unit)
            {
                case ProductUnit.Piece:
                    return "Штука";
                case ProductUnit.Kg:
                    return "Килограмм";
                case ProductUnit.Liter:
                    return "Литр";
                default:
                    return unit.ToString();
            }
        }
    }
}
