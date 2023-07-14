using System;
using System.Collections.Generic;
using System.Text;
using HistoryService.Localization;
using Volo.Abp.Application.Services;

namespace HistoryService;

/* Inherit your application services from this class.
 */
public abstract class HistoryServiceAppService : ApplicationService
{
    protected HistoryServiceAppService()
    {
        LocalizationResource = typeof(HistoryServiceResource);
    }
}
