using UserService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace UserService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(UserServiceEntityFrameworkCoreModule),
    typeof(UserServiceApplicationContractsModule)
    )]
public class UserServiceDbMigratorModule : AbpModule
{
}
