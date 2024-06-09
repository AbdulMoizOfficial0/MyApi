using Microsoft.AspNetCore.Mvc;
using MyApi.DTOs;
using MyApi.Services;
using MyApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemsService _orderItemService;

        public OrderItemController(IOrderItemsService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderItemDTO>>> GetAllOrderItems()
        {
            var orderItems = await _orderItemService.GetAllAsync();
            return Ok(orderItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItemDTO>> GetOrderItemById(int id)
        {
            var orderItem = await _orderItemService.GetByIdAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }
            return Ok(orderItem);
        }

        [HttpPost]
        public async Task<ActionResult> AddOrderItem(OrderItemDTO orderItemDto)
        {
            await _orderItemService.AddAsync(orderItemDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOrderItem(int id, OrderItemDTO orderItemDto)
        {
            await _orderItemService.UpdateAsync(id, orderItemDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOrderItem(int id)
        {
            await _orderItemService.DeleteAsync(id);
            return Ok();
        }
    }
}
