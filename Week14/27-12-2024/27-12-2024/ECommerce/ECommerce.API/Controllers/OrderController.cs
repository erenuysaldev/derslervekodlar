using ECommerce.Business.Abstract;
using ECommerce.Shared.ComplexTypes;
using ECommerce.Shared.DTOs;
using ECommerce.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
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

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var response = await _orderService.GetOrderAsync(id);
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var response = await _orderService.GetOrdersAsync();
            return CreateResponse(response);
        }

        [Authorize]
        [HttpGet("status/{orderStatus}")]
        public async Task<IActionResult> GetOrders(OrderStatus orderStatus)
        {
            var response = await _orderService.GetOrdersAsync(orderStatus);
            return CreateResponse(response);
        }

        private IActionResult CreateResponse<T>(ResponseDTO<T> response)
        {
            if (response.IsSucceded)
            {
                return Ok(response.Data);
            }
            return StatusCode(response.StatusCode, response.Errors);
        }
        [Authorize]
        [HttpDelete]
    }
}
