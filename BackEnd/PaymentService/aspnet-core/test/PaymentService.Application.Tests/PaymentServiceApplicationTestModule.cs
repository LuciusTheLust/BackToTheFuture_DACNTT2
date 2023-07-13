using Volo.Abp.Modularity;

namespace PaymentService;

[DependsOn(
    typeof(PaymentServiceApplicationModule),
    typeof(PaymentServiceDomainTestModule)
    )]
public class PaymentServiceApplicationTestModule : AbpModule
{

}
