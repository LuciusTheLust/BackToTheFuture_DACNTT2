using System.Threading.Tasks;

namespace HistoryService.Data;

public interface IHistoryServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
