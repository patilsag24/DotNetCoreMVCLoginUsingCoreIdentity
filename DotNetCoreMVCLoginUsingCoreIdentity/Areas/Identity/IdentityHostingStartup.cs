using System;
using DotNetCoreMVCLoginUsingCoreIdentity.Areas.Identity.Data;
using DotNetCoreMVCLoginUsingCoreIdentity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DotNetCoreMVCLoginUsingCoreIdentity.Areas.Identity.IdentityHostingStartup))]
namespace DotNetCoreMVCLoginUsingCoreIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DotNetCoreMVCLoginUsingCoreIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DotNetCoreMVCLoginUsingCoreIdentityContextConnection")));

                services.AddDefaultIdentity<DotNetCoreMVCLoginUsingCoreIdentityUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<DotNetCoreMVCLoginUsingCoreIdentityContext>();
            });
        }
    }
}