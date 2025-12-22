using AutoMapper;
using BusinessLogic.DTOs.Payments;
using BusinessLogic.Interface;
using BusinessLogic.Repository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IGeneralRepository<Payment> _paymentRepo;
        private readonly IMapper _mapper;

        public PaymentService(
            IGeneralRepository<Payment> paymentRepo,
            IMapper mapper)
        {
            _paymentRepo = paymentRepo;
            _mapper = mapper;
        }

        // GET /api/payments
        public async Task<IEnumerable<PaymentResponseDto>> GetAllAsync()
        {
            var payments = await _paymentRepo.GetAll()
                .Include(p => p.Subscription)
                .ToListAsync();

            return _mapper.Map<IEnumerable<PaymentResponseDto>>(payments);
        }

        // GET /api/payments/{id}
        public async Task<PaymentResponseDto?> GetByIdAsync(int id)
        {
            var payment = await _paymentRepo.GetAll()
                .Include(p => p.Subscription)
                .FirstOrDefaultAsync(p => p.Id == id);

            return payment == null ? null : _mapper.Map<PaymentResponseDto>(payment);
        }

        // GET /api/craftsmen/{craftsmanId}/payments
        public async Task<IEnumerable<PaymentResponseDto>> GetByCraftsmanAsync(int craftsmanId)
        {
            var payments = await _paymentRepo.GetAll()
                .Include(p => p.Subscription)
                .Where(p => p.Subscription!.CraftsmanId == craftsmanId)
                .ToListAsync();

            return _mapper.Map<IEnumerable<PaymentResponseDto>>(payments);
        }

        // POST /api/payments
        public async Task<PaymentResponseDto> CreateAsync(CreatePaymentDto dto)
        {
            var payment = _mapper.Map<Payment>(dto);

            await _paymentRepo.Add(payment);

            // reload with relation
            var savedPayment = await _paymentRepo.GetAll()
                .Include(p => p.Subscription)
                .FirstAsync(p => p.Id == payment.Id);

            return _mapper.Map<PaymentResponseDto>(savedPayment);
        }
    }
}
