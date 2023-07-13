using System.Threading.Tasks;

namespace UserService.Data;

public interface IUserServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
