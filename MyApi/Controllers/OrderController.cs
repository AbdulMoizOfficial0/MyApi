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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDTO>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> GetOrderById(int id)
        {
            var order = await _orderService.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult> AddOrder(OrderDTO orderDto)
        {
            await _orderService.AddAsync(orderDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOrder(int id, OrderDTO orderDto)
        {
            await _orderService.UpdateAsync(id, orderDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            await _orderService.DeleteAsync(id);
            return Ok();
        }
    }
}
