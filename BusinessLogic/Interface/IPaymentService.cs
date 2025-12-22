using BusinessLogic.DTOs.Payments;

namespace BusinessLogic.Interface
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentResponseDto>> GetAllAsync();
        Task<PaymentResponseDto?> GetByIdAsync(int id);
        Task<IEnumerable<PaymentResponseDto>> GetByCraftsmanAsync(int craftsmanId);
        Task<PaymentResponseDto> CreateAsync(CreatePaymentDto dto);
    }
}
