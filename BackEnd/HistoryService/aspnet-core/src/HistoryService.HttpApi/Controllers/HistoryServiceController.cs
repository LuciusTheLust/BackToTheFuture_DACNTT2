using HistoryService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HistoryService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HistoryServiceController : AbpControllerBase
{
    protected HistoryServiceController()
    {
        LocalizationResource = typeof(HistoryServiceResource);
    }
}
