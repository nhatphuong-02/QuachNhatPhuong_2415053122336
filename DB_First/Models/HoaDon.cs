using System;
using System.Collections.Generic;

namespace DB_First.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public DateOnly NgayLap { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;
}
