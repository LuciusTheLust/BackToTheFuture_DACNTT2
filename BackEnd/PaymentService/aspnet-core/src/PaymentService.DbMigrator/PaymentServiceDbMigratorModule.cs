using PaymentService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PaymentService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaymentServiceEntityFrameworkCoreModule),
    typeof(PaymentServiceApplicationContractsModule)
    )]
public class PaymentServiceDbMigratorModule : AbpModule
{
}
