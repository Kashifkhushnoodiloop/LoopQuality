using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Interloop.LoopQuality.Data;
using Volo.Abp.DependencyInjection;

namespace Interloop.LoopQuality.EntityFrameworkCore;

public class EntityFrameworkCoreLoopQualityDbSchemaMigrator
    : ILoopQualityDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLoopQualityDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LoopQualityDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LoopQualityDbContext>()
            .Database
            .MigrateAsync();
    }
}
