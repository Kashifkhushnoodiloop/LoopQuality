using Interloop.LoopQuality.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Interloop.LoopQuality.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LoopQualityEntityFrameworkCoreModule),
    typeof(LoopQualityApplicationContractsModule)
)]
public class LoopQualityDbMigratorModule : AbpModule
{
}
