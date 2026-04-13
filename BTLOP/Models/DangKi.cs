namespace BTLOP.Models
{
    public class DangKi
    {
        public int Id { get; set; }
        public string SinhVienId { get; set; }
        public string KhoaHocId { get; set; }
        public  SinhVien sv { get; set; }
        public KhoaHoc kh { get; set; }
    }
}
