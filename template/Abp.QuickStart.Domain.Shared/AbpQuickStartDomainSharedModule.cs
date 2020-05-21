using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.QuickStart
{
    public class AbpQuickStartDomainSharedModule :
        AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(config =>
            {
                config.FileSets.AddEmbedded<AbpQuickStartDomainSharedModule>("Abp.QuickStart");
            });
        }
    }
}
