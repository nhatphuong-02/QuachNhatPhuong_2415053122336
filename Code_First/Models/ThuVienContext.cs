using Microsoft.EntityFrameworkCore;

namespace Code_First.Models
{
    public class ThuVienContext : DbContext
    {
        public ThuVienContext(DbContextOptions<ThuVienContext> options)
            : base(options)
        {
        }

        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}