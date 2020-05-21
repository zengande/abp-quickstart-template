using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.QuickStart.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpQuickStartDomainModule)
        )]
    public class AbpQuickStartEntityFrameworkCoreModule :
        AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpQuickStartDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseMySQL();
            });
        }
    }
}
