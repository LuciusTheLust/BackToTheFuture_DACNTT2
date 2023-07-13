using Acme.Product.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Product;

[DependsOn(
    typeof(ProductEntityFrameworkCoreTestModule)
    )]
public class ProductDomainTestModule : AbpModule
{

}
