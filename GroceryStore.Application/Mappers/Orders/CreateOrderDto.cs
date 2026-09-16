using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.DTO.Orders
{
    public sealed class CreateOrderDto
    {
        public Guid? CustomerId { get; init; }
        public string CustomerName { get; init; } = "";
        public string PhoneNumber { get; init; } = "";
        public List<OrderItemDto> Items { get; init; } = new List<OrderItemDto>();
    }
}
