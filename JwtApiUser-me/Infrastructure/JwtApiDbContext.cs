using JwtApiUser_me.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace JwtApiUser_me.Infrastructure
{
    public class JwtApiDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;
        public JwtApiDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("backDB"));
        }
        public DbSet<User> Users { get; set; }
    }
}
