using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BountyCraft.WebMVC7.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BCProfile> Profiles { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ProfileItem> ProfilesItem { get; set; }
    }
}