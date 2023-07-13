using UserService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace UserService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class UserServiceController : AbpControllerBase
{
    protected UserServiceController()
    {
        LocalizationResource = typeof(UserServiceResource);
    }
}
