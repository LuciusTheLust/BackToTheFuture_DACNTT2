using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace UserService.Data;

/* This is used if database provider does't define
 * IUserServiceDbSchemaMigrator implementation.
 */
public class NullUserServiceDbSchemaMigrator : IUserServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
