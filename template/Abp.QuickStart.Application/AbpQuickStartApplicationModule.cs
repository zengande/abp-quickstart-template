using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Abp.QuickStart
{
    [DependsOn(
        typeof(AbpQuickStartDomainModule),
        typeof(AbpQuickStartApplicationContractsModule)
        )]
    public class AbpQuickStartApplicationModule :
        AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpQuickStartApplicationModule>();
            });
        }
    }
}
