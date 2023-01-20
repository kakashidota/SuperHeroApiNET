using Microsoft.EntityFrameworkCore;
using HeroAPI.Models;

namespace HeroAPI.Data
{
    public class ApiDbContext : DbContext
    {

        public DbSet<Hero> Heroes { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

    }
}
