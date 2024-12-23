using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Interloop.LoopQuality.Data;

/* This is used if database provider does't define
 * ILoopQualityDbSchemaMigrator implementation.
 */
public class NullLoopQualityDbSchemaMigrator : ILoopQualityDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
