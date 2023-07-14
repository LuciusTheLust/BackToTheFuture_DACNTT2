using HistoryService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HistoryService;

[DependsOn(
    typeof(HistoryServiceEntityFrameworkCoreTestModule)
    )]
public class HistoryServiceDomainTestModule : AbpModule
{

}
