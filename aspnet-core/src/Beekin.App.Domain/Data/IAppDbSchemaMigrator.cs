using System.Threading.Tasks;

namespace Beekin.App.Data;

public interface IAppDbSchemaMigrator
{
    Task MigrateAsync();
}
