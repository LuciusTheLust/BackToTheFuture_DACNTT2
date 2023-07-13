using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Product;

[Dependency(ReplaceServices = true)]
public class ProductBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Product";
}
