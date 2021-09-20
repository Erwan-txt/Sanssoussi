using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Sanssoussi.Areas.Identity;
using Sanssoussi.Areas.Identity.Data;
using Sanssoussi.Data;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]

namespace Sanssoussi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(
                (context, services) =>
                {
                    services.AddDbContext<SanssoussiContext>(
                        options =>
                            options.UseSqlite(
                                context.Configuration.GetConnectionString("SanssoussiContextConnection")));

                    services.AddDefaultIdentity<SanssoussiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                        .AddEntityFrameworkStores<SanssoussiContext>();
                });
        }
    }
}