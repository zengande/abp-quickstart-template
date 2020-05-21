using Abp.QuickStart.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.QuickStart.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpQuickStartDbSchemaMigrator :
        IAbpQuickStartDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;
        public EntityFrameworkCoreAbpQuickStartDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpQuickStartMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
