using System;
using System.Collections.Generic;

namespace BTThayHuy_DTBFirst.Models;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string TenSp { get; set; } = null!;

    public double Gia { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
