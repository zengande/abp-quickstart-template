using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.QuickStart.EntityFrameworkCore
{
    public class AbpQuickStartMigrationsDbContext :
        AbpDbContext<AbpQuickStartMigrationsDbContext>
    {
        public AbpQuickStartMigrationsDbContext(DbContextOptions<AbpQuickStartMigrationsDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigureAbpQuickStartModels();
        }
    }
}
