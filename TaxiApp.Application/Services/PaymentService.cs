using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;

    public PaymentService(IPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    public async Task<int> AddPaymentAsync(PaymentDto paymentDto)
    {
        Payment payment = new Payment();
        payment.Amount = paymentDto.Amount;
        payment.PaymentId = paymentDto.PaymentId;
        payment.PaymentTime = paymentDto.PaymentTime;
        payment.RideId = paymentDto.RideId;

         return   await _paymentRepository.AddPaymentAsync(payment);        
    }

    public async Task<IEnumerable<PaymentDto>> GetAllPaymentsAsync()
    {
        return (await _paymentRepository.GetAllPaymentsAsync()).Select(p => new PaymentDto
        {
            Amount = p.Amount,
            PaymentId = p.PaymentId,
            PaymentTime = p.PaymentTime,
            RideId = p.RideId
        });
    }

    public async Task<PaymentDto> GetPaymentByIdAsync(int id)
    {
        return (await _paymentRepository.GetPaymentByIdAsync(id)) is Payment payment ? new PaymentDto
        {
            Amount = payment.Amount,
            PaymentId = payment.PaymentId,
            PaymentTime = payment.PaymentTime,
            RideId = payment.RideId
        } : null!;
    }
}
