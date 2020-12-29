using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreMVCLoginUsingCoreIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMVCLoginUsingCoreIdentity.Data
{
    public class DotNetCoreMVCLoginUsingCoreIdentityContext : IdentityDbContext<DotNetCoreMVCLoginUsingCoreIdentityUser>
    {
        public DotNetCoreMVCLoginUsingCoreIdentityContext(DbContextOptions<DotNetCoreMVCLoginUsingCoreIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
