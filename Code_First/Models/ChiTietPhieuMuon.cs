using Code_First.Models;
using System.ComponentModel.DataAnnotations;

public class ChiTietPhieuMuon
{
    [Key]
    public int MaCT { get; set; }

    public string MaPM { get; set; }
    public string MaSach { get; set; }
    public int SoLuong { get; set; }

    public PhieuMuon PhieuMuon { get; set; }
    public Sach Sach { get; set; }
}