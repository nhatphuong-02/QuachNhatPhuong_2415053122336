using System.ComponentModel.DataAnnotations;

namespace Code_First.Models
{
    public class DocGia
    {
        [Key]
        public string MaDG { get; set; }

        public string TenDG { get; set; }
        public string SDT { get; set; }

        public List<PhieuMuon> PhieuMuons { get; set; }
    }
}