using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Abp.QuickStart.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpQuickStartEntityFrameworkCoreModule)
        )]
    public class AbpQuickStartEntityFrameworkCoreDbMigrationsModule :
        AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpQuickStartMigrationsDbContext>();
        }
    }
}
