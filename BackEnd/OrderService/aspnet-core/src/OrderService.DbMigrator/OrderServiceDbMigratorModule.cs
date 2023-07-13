using OrderService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OrderService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrderServiceEntityFrameworkCoreModule),
    typeof(OrderServiceApplicationContractsModule)
    )]
public class OrderServiceDbMigratorModule : AbpModule
{
}
