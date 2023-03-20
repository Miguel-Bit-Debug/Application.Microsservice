using AutoMapper;
using Domain.DTOs.Request;
using Domain.Models;
using Microsoft.AspNetCore.SignalR;

namespace Domain.Hubs
{
    public class ProductNotificationHub : Hub
    {
        private readonly IMapper _mapper;

        public ProductNotificationHub(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<string> NotificationNewProduct(string productName, ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);

            await Clients.All.SendAsync("ReceivedMessage");

            return $"Novo produto adicionado! {product.Id} - {product.ProductName}";
        }
    }
}
