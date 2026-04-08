namespace Code_First.Models
{
    public class ChiTietPhieuMuon
    {
        public int MaCT { get; set; }

        public string MaPM { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }

        public PhieuMuon PhieuMuon { get; set; }
        public Sach Sach { get; set; }
    }
}
