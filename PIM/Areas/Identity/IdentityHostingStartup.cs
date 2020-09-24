using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PIM.Areas.Identity.Data;
using PIM.Data;

[assembly: HostingStartup(typeof(PIM.Areas.Identity.IdentityHostingStartup))]
namespace PIM.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PIMContext1>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PIMContext1Connection")));

                services.AddDefaultIdentity<PIMPerson>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PIMContext1>();
            });
        }
    }
}