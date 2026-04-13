namespace BTLOP.Models
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<DangKi> DangKis { get; set; }
    }
}
