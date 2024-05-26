using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Repository;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;

    public PaymentService(IPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    public async Task AddPaymentAsync(PaymentDto paymentDto)
    {
        var payment = new Payment
        {
            // Aquí debes mapear las propiedades de paymentDto a las de payment
            // Por ejemplo:
            // Id = paymentDto.Id,
            // Amount = paymentDto.Amount,
            // Date = paymentDto.Date,
            // etc.
        };

        await _paymentRepository.AddPaymentAsync(payment);
    }

    public async Task<IEnumerable<PaymentDto>> GetAllPaymentsAsync()
    {
        var payments = await _paymentRepository.GetAllPaymentsAsync();

        return payments.Select(payment => new PaymentDto
        {
            // Aquí debes mapear las propiedades de payment a las de PaymentDto
            // Por ejemplo:
            // Id = payment.Id,
            // Amount = payment.Amount,
            // Date = payment.Date,
            // etc.
        });
    }

    public async Task<PaymentDto> GetPaymentByIdAsync(int id)
    {
        var payment = await _paymentRepository.GetPaymentByIdAsync(id);

        if (payment == null)
        {
            return null;
        }

        return new PaymentDto
        {
            // Aquí debes mapear las propiedades de payment a las de PaymentDto
            // Por ejemplo:
            // Id = payment.Id,
            // Amount = payment.Amount,
            // Date = payment.Date,
            // etc.
        };
    }
}
