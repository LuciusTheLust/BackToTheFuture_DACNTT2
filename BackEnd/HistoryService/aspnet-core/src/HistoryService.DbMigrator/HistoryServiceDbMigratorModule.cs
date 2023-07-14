using HistoryService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HistoryService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HistoryServiceEntityFrameworkCoreModule),
    typeof(HistoryServiceApplicationContractsModule)
    )]
public class HistoryServiceDbMigratorModule : AbpModule
{
}
