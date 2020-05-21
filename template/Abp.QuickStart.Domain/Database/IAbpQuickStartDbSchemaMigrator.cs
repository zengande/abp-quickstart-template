using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abp.QuickStart.Database
{
    public interface IAbpQuickStartDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
