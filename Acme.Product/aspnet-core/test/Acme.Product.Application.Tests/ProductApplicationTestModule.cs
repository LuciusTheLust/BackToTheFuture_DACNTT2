using Volo.Abp.Modularity;

namespace Acme.Product;

[DependsOn(
    typeof(ProductApplicationModule),
    typeof(ProductDomainTestModule)
    )]
public class ProductApplicationTestModule : AbpModule
{

}
