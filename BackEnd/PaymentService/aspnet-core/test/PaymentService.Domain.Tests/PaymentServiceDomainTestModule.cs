using PaymentService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PaymentService;

[DependsOn(
    typeof(PaymentServiceEntityFrameworkCoreTestModule)
    )]
public class PaymentServiceDomainTestModule : AbpModule
{

}
