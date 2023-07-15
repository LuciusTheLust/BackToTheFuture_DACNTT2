using PaymentService.Payments;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.PaymentService.Payments;

public interface IPaymentAppService :
    ICrudAppService< //Defines CRUD methods
        PaymentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePaymentDto> //Used to create/update a book
{

}
