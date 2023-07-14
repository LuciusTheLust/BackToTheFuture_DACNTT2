using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HistoryService.Data;
using Volo.Abp.DependencyInjection;

namespace HistoryService.EntityFrameworkCore;

public class EntityFrameworkCoreHistoryServiceDbSchemaMigrator
    : IHistoryServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHistoryServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HistoryServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HistoryServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
