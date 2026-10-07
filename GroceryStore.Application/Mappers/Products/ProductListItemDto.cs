using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Mappers.Product
{
    public sealed class ProductListItemDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Sku { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public ProductUnit Unit { get; init; }
        public string UnitDisplayName { get; init; } = string.Empty;
        public Guid CategoryId { get; init; }
        public string CategoryName { get; init; } = string.Empty;
        public bool IsActive { get; init; }
    }
}
