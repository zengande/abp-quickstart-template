using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abp.QuickStart.EntityFrameworkCore
{
    public class AbpQuickStartMigrationsDbContextFactory :
        IDesignTimeDbContextFactory<AbpQuickStartMigrationsDbContext>
    {
        public AbpQuickStartMigrationsDbContext CreateDbContext(string[] args)
        {
            AbpQuickStartEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpQuickStartMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new AbpQuickStartMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
