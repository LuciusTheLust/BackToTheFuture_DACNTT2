using UserService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace UserService;

[DependsOn(
    typeof(UserServiceEntityFrameworkCoreTestModule)
    )]
public class UserServiceDomainTestModule : AbpModule
{

}
