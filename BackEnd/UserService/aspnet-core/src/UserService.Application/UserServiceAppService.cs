using System;
using System.Collections.Generic;
using System.Text;
using UserService.Localization;
using Volo.Abp.Application.Services;

namespace UserService;

/* Inherit your application services from this class.
 */
public abstract class UserServiceAppService : ApplicationService
{
    protected UserServiceAppService()
    {
        LocalizationResource = typeof(UserServiceResource);
    }
}
