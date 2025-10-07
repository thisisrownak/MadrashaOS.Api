using MadrashaOS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace MadrashaOS.Api.Data
{
    public class MadrashaDbContext : DbContext
    {
        public MadrashaDbContext(DbContextOptions<MadrashaDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
