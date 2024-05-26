using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;

namespace TaxiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        [Route("GetAllPayments")]         
        public async Task<IActionResult> GetAllPayments()
        {
            var response = await _paymentService.GetAllPaymentsAsync();
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetPaymentById")]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var response = await _paymentService.GetPaymentByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        [Route("AddPayment")]
        public async Task<IActionResult> AddPayment([FromBody] PaymentDto paymentDto)
        {
            int response = await _paymentService.AddPaymentAsync(paymentDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

    }
}
