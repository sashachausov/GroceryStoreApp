using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Sku { get; private set; }
        public decimal Price { get; private set; }
        public ProductUnit Unit { get; private set; }
        public bool IsActive { get; private set; }
        
        private Product() { }

        public Product(string name, string sku, decimal price, ProductUnit unit)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetSku(sku);
            SetPrice(price);
            Unit = unit;
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

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
