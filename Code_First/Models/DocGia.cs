namespace Code_First.Models
{
    public class DocGia
    {
        public string MaDG {  get; set; }
        public string TenDG { get; set; }
        public string SDT { get; set; }
        public List<PhieuMuon> PhieuMuons { get; set; }
    }
}
