using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Interfaces;
using GroceryStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Application.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository order, IProductRepository product, IUnitOfWork unit)
        {
            this._orderRepository = order;
            this._productRepository = product;
            this._unitOfWork = unit;
        }

        public async Task<Order> CreateDraftAsync()
        {
            var order = new Order();
            await _orderRepository.AddAsync(order);
            await _unitOfWork.SaveChangesAsync();
            return order;
        }

        public async Task AddItemAsync(Guid orderId, Guid productId, decimal quantity)
        {
            var order = await GetRequired(orderId);
            var product = await _productRepository.GetByIdAsync(productId) ?? throw new NotFoundException("Product not found");
            order.AddItem(new OrderItem(product.Id, product.Name, product.Price, quantity));
            await _orderRepository.UpdateAsync(order);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ConfirmAsync(Guid orderId)
        {
            var order = await GetRequired(orderId);
            order.Confirm();
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task PayAsync(Guid orderId)
        {
            var order = await GetRequired(orderId);
            order.Pay();
            await _unitOfWork.SaveChangesAsync();
        }

        private async Task<Order> GetRequired(Guid id) => await _orderRepository.GetByIdAsync(id) ?? throw new NotFoundException("Order not found");

        public async Task GetRunningOrdersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
