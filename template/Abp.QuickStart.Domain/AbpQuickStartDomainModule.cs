using Volo.Abp.Modularity;

namespace Abp.QuickStart
{
    [DependsOn(
        typeof(AbpQuickStartDomainSharedModule)
        )]
    public class AbpQuickStartDomainModule :
        AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
