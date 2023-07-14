using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HistoryService;

[Dependency(ReplaceServices = true)]
public class HistoryServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HistoryService";
}
