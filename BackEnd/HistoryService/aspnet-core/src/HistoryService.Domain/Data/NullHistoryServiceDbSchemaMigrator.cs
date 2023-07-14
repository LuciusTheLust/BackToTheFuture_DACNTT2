using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HistoryService.Data;

/* This is used if database provider does't define
 * IHistoryServiceDbSchemaMigrator implementation.
 */
public class NullHistoryServiceDbSchemaMigrator : IHistoryServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
