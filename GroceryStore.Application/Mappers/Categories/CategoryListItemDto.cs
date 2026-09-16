using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Mappers.Categories
{
    public sealed class CategoryListItemDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Relative image path.
        /// If null or empty, the UI should use DefaultImage.png
        /// </summary>
        public string? ImagePath { get; init; }
        public bool IsUsingDefaultImage => string.IsNullOrWhiteSpace(ImagePath);
        public int ProductCount { get; init; }
        public bool IsActive { get; init; }
    }
}
