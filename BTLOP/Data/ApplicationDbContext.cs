using Microsoft.EntityFrameworkCore;
using BTLOP.Models; 
namespace BTLOP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<SinhVien> sv { get; set; }
        public DbSet<KhoaHoc> kh { get; set; }
        public DbSet<DangKi> dk { get; set; }
    }
}
