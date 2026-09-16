using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime CreatedAtUtc { get; private set; } = DateTime.UtcNow;
        public OrderStatus Status { get; private set; } = OrderStatus.Draft;
        public string OrderNumber { get; private set; }

        private readonly List<OrderItem> _items = new List<OrderItem>();        
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        //public IReadOnlyCollection<OrderItem> Items { get { return _items.AsReadOnly(); } }

        public decimal Total => _items.Sum(i => i.LineTotal);

        // Required for JSON serialization
        public Order() { }

        public Order(string orderNumber) : this()
        {
            OrderNumber = orderNumber;
        }

        public void AddItem(OrderItem item)
        {
            var existing = _items.FirstOrDefault(i => i.ProductId == item.ProductId);

            if (existing != null)
                existing.ChangeQuantity(existing.Quantity + item.Quantity);
            else
                _items.Add(item);
        }

        public void RemoveItem(Guid productId)
        {
            EnsureDraft();
            _items.RemoveAll(i => i.ProductId == productId);
        }

        public void Confirm()
        {
            EnsureDraft();
            if (!_items.Any())
                throw new InvalidOperationException("Cannot confirm empty order");
            Status = OrderStatus.Confirmed;
        }        

        public void Pay()
        {
            if (Status != OrderStatus.Confirmed)
                throw new InvalidOperationException("Only confirmed orders can be paid");
            Status = OrderStatus.Paid;
        }

        public void Cancel()
        {
            if (Status == OrderStatus.Paid)
                throw new InvalidOperationException("Cannot cancel paid order");
            Status = OrderStatus.Cancelled;
        }

        private void EnsureDraft()
        {
            if (Status != OrderStatus.Draft)
                throw new InvalidOperationException("Only draft orders can be modified");
        }
    }
}
