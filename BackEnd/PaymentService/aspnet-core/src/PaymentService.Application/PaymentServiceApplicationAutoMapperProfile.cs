using Acme.PaymentService.Payments;
using AutoMapper;
using PaymentService.Payments;

namespace Acme.PaymentService;

public class PaymentServiceApplicationAutoMapperProfile : Profile
{
    public PaymentServiceApplicationAutoMapperProfile()
    {
        CreateMap<Payment, PaymentDto>();
        CreateMap<CreateUpdatePaymentDto, Payment>();
    }
}
