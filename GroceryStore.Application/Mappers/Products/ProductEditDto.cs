using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Mappers.Product
{
    public sealed class ProductEditDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public ProductUnit Unit { get; set; }
        public Guid CategoryId { get; set; }
    }
}
