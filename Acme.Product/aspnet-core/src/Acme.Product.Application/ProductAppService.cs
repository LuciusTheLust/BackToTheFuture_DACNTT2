using System;
using System.Collections.Generic;
using System.Text;
using Acme.Product.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Product;

/* Inherit your application services from this class.
 */
public abstract class ProductAppService : ApplicationService
{
    protected ProductAppService()
    {
        LocalizationResource = typeof(ProductResource);
    }
}
