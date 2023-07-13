using Acme.Product.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Product.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductEntityFrameworkCoreModule),
    typeof(ProductApplicationContractsModule)
    )]
public class ProductDbMigratorModule : AbpModule
{
}
