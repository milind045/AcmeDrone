using AcmeDrone.Areas.Identity.Data;
using AcmeDrone.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AcmeDrone.Areas.Identity.IdentityHostingStartup))]
namespace AcmeDrone.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AcmeDroneContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("AcmeDroneContextConnection")));

                services.AddDefaultIdentity<AcmeDroneUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<AcmeDroneContext>();
            });
        }
    }
}