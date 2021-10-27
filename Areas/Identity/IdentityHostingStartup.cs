using System;
using Discussions.Areas.Identity.Data;
using Discussions.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Discussions.Areas.Identity.IdentityHostingStartup))]
namespace Discussions.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<DiscussionsContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DiscussionsContextConnection")));

                services.AddIdentity<DiscussionsUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount=false)
                    .AddEntityFrameworkStores<DiscussionsContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();
                services.AddControllersWithViews();
            });
        }
    }
}