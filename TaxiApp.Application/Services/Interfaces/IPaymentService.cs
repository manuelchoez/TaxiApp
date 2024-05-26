using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentDto> GetPaymentByIdAsync(int id);
        Task<IEnumerable<PaymentDto>> GetAllPaymentsAsync();
        Task AddPaymentAsync(PaymentDto payment);
    }
}
