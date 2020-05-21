using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Abp.QuickStart
{
    [DependsOn(
        typeof(AbpQuickStartApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
        )]
    public class AbpQuickStartAPIModule :
        AbpModule
    {
    }
}
