using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Abp.QuickStart.EntityFrameworkCore
{
    public static class AbpQuickStartDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpQuickStartModels(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
        }
    }
}
