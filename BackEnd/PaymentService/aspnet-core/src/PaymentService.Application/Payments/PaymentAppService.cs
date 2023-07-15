using PaymentService.Payments;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.PaymentService.Payments;

public class PaymentAppService :
    CrudAppService<
        Payment, //The Book entity
        PaymentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePaymentDto>, //Used to create/update a book
    IPaymentAppService //implement the IBookAppService
{
    public PaymentAppService(IRepository<Payment, Guid> repository)
        : base(repository)
    {

    }
}
