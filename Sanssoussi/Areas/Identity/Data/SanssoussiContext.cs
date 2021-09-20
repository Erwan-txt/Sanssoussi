using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Sanssoussi.Areas.Identity.Data;

namespace Sanssoussi.Data
{
    public class SanssoussiContext : IdentityDbContext<SanssoussiUser>
    {
        public SanssoussiContext(DbContextOptions<SanssoussiContext> options)
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