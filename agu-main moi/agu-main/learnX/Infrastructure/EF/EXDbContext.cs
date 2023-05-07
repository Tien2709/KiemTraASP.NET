using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF
{
    public class EXDbContext : DbContext
    {
        public EXDbContext(DbContextOptions<EXDbContext> options) : base(options)
        {
        }

        public DbSet<User> user { get; set; }
        public DbSet<KhachHang> khachHang { get; set; }
    }
}
