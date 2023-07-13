using Acme.Product.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Product.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductController : AbpControllerBase
{
    protected ProductController()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
