using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Entities
{
    public class Product
    {
        [JsonInclude]        
        public Guid Id { get; private set; }
        [JsonInclude]
        public string Name { get; private set; } = string.Empty;
        [JsonInclude]
        public string Sku { get; private set; } = string.Empty;
        [JsonInclude]
        public decimal Price { get; private set; }
        [JsonInclude]
        public ProductUnit Unit { get; private set; }
        [JsonInclude]
        public Guid CategoryId { get; private set; }
        [JsonInclude]
        public bool IsActive { get; private set; }
        
        public Product() { }

        public Product(string name, string sku, decimal price, ProductUnit unit, Guid categoryId)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetSku(sku);
            SetPrice(price);
            SetUnit(unit);
            SetCategory(categoryId);
            IsActive = true;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Product name cannot be empty");

            Name = name.Trim();
        }

        public void SetSku(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
                throw new ArgumentNullException("SKU cannot be empty");

            Sku = sku.Trim();
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero");

            Price = price;
        }

        public void SetUnit(ProductUnit unit)
        {
            Unit = unit;
        }

        public void SetCategory(Guid categoryId)
        {
            if (categoryId == Guid.Empty)
                throw new ArgumentException("Category must be selected.");

            CategoryId = categoryId;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
