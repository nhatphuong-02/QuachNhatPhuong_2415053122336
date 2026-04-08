namespace Code_First.Models
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public double Gia { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
    }
}
