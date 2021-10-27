using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discussions.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Discussions.Data
{
    public class DiscussionsContext : IdentityDbContext<DiscussionsUser>
    {
        public DiscussionsContext(DbContextOptions<DiscussionsContext> options)
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
