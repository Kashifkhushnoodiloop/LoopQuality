using System.Threading.Tasks;

namespace Interloop.LoopQuality.Data;

public interface ILoopQualityDbSchemaMigrator
{
    Task MigrateAsync();
}
