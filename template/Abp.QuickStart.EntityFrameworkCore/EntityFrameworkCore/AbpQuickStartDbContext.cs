using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.QuickStart.EntityFrameworkCore
{
    public class AbpQuickStartDbContext :
        AbpDbContext<AbpQuickStartDbContext>
    {
        public AbpQuickStartDbContext(DbContextOptions<AbpQuickStartDbContext> options) 
            : base(options)
        {
        }
    }
}
