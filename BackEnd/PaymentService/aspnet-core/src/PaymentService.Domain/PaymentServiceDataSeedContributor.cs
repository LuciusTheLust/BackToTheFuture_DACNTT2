using System;
using System.Threading.Tasks;
using Acme.PaymentService.Payments;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.PaymentService;

public class PaymentServiceDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Payment, Guid> _paymentRepository;

    public PaymentServiceDataSeederContributor(IRepository<Payment, Guid> paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _paymentRepository.GetCountAsync() <= 0)
        {
            await _paymentRepository.InsertAsync(
                new Payment
                {
                    Balance = "abc",
                    Name = "xyz",
                    type = PaymentType.cash,
                    UserId = "ccc"
                },
                autoSave: true
            );

            await _paymentRepository.InsertAsync(
               new Payment
               {
                   Balance = "fgv",
                   Name = "tyr",
                   type = PaymentType.creditcards,
                   UserId = "fff"
               },
               autoSave: true
           );
        }
    }
}
