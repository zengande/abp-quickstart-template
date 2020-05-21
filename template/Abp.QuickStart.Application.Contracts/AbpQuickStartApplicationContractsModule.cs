using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Abp.QuickStart
{
    [DependsOn(
        typeof(AbpQuickStartDomainSharedModule)
        )]
    public class AbpQuickStartApplicationContractsModule :
        AbpModule
    {
    }
}
