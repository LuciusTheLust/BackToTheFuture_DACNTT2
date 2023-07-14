using Volo.Abp.Modularity;

namespace HistoryService;

[DependsOn(
    typeof(HistoryServiceApplicationModule),
    typeof(HistoryServiceDomainTestModule)
    )]
public class HistoryServiceApplicationTestModule : AbpModule
{

}
