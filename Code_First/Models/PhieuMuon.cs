using Code_First.Models;
using System.ComponentModel.DataAnnotations;

public class PhieuMuon
{
    [Key]
    public string MaPM { get; set; }
    public string MaDG { get; set; }
    public DateTime NgayMuon { get; set; }
    public DocGia DocGia { get; set; }
    public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
}