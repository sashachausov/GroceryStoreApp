using GroceryStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.DTO.Orders
{
    public sealed class OrderListItemDto
    {
        public Guid Id { get; init; }
        public string OrderNumber { get; init; } = "";
        public string CustomerName { get; init; } = "";
        public string CustomerPhone { get; init; } = "";
        public decimal Total { get; init; }
        public OrderStatus Status { get; init; }
        public DateTime CreatedAtUtc { get; init; }
    }
}
