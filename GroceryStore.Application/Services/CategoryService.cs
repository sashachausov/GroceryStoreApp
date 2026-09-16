using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Interfaces;
using GroceryStore.Application.Mappers.Categories;
using GroceryStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Services
{
    public class CategoryService
    {
        private const string DefaultCategoryImagePath = "Images/System/DefaultImage.png";
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryListItemDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Where(c => c.IsActive).OrderBy(c => c.Name).Select(c => MapToListItemDto(c, productCount: 0)).ToList();
        }

        public async Task<List<CategoryListItemDto>> SearchAsync(string? searchText)
        {
            var categories = await GetAllAsync();

            if (string.IsNullOrWhiteSpace(searchText)) 
                return categories;

            return categories.Where(c => c.Name.Contains(searchText.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public async Task<CategoryEditDto> GetForEditAsync(Guid id)
        {
            var category = await GetRequiredAsync(id);

            return new CategoryEditDto
            {
                Id = id,
                Name = category.Name,
                RelativeImagePath = category.ImagePath,
            };
        }

        public async Task<Guid> CreateAsync(CategoryEditDto dto)
        {
            ValidateDto(dto);
            await EnsureNameIsUniqueAsync(dto.Name);
            var category = new Category(dto.Name, dto.RelativeImagePath);
            await _categoryRepository.AddAsync(category);
            return category.Id;
        }

        public async Task UpdateAsync(CategoryEditDto dto)
        {
            if (dto.Id == null)
                throw new ValidationException("Category id is required for update."); 
            
            ValidateDto(dto);

            var category = await GetRequiredAsync(dto.Id.Value);
            await EnsureNameIsUniqueAsync(dto.Name, dto.Id.Value);
            category.SetName(dto.Name);
            category.SetImagePath(dto.RelativeImagePath);
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeactivateAsync(Guid id)
        {
            var category = await GetRequiredAsync(id);
            category.Deactivate();
            await _categoryRepository.UpdateAsync(category);
        }

        public string GetDisplayImagePath(CategoryListItemDto category)
        {
            if (string.IsNullOrWhiteSpace(category.ImagePath))
                return DefaultCategoryImagePath;
            return category.ImagePath;
        }

        private async Task<Category> GetRequiredAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
                throw new NotFoundException("Category not found.");
            return category;
        }

        private static CategoryListItemDto MapToListItemDto(Category category, int productCount)
        {
            return new CategoryListItemDto
            {
                Id = category.Id,
                Name = category.Name,
                ImagePath = category.ImagePath,
                ProductCount = productCount,
                IsActive = category.IsActive,
            };
        }

        private async Task EnsureNameIsUniqueAsync(string name, Guid? currentCategoryId = null)
        {
            var categories = await _categoryRepository.GetAllAsync();

            var exists = categories.Any(c => c.IsActive && c.Name.Equals(name.Trim(), StringComparison.OrdinalIgnoreCase) && c.Id != currentCategoryId);

            if (exists)
                throw new ValidationException("Category with this name already exists.");
        }

        private static void ValidateDto(CategoryEditDto? dto)
        {
            if (dto == null) 
                throw new ValidationException("Category data is required.");

            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ValidationException("Category name is required.");
        }
    }
}
