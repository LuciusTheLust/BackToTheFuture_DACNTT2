using System.Threading.Tasks;

namespace PaymentService.Data;

public interface IPaymentServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
