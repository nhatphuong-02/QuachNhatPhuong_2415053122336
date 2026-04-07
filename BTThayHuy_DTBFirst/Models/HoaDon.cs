using System;
using System.Collections.Generic;

namespace BTThayHuy_DTBFirst.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public int SoLuong { get; set; }

    public DateOnly NgayLap { get; set; }

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
