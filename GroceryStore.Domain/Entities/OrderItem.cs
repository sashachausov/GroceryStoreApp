using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Entities
{
    public class OrderItem
    {
        public Guid ProductId { get; private set; }
        public string ProductName { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal LineTotal => UnitPrice * Quantity;

        public OrderItem(Guid productId, string productName, decimal unitPrice, decimal quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be higher than 0");
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public void ChangeQuantity(decimal quantity)         
        { 
            if (quantity <= 0) throw new ArgumentException("Quantity must be higher than 0");
            Quantity = quantity;
        }
    }
}
