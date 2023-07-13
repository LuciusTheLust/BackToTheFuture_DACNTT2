using System.Threading.Tasks;

namespace Acme.Product.Data;

public interface IProductDbSchemaMigrator
{
    Task MigrateAsync();
}
