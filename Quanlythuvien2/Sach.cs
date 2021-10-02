using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien2
{
    public class Sach
    {
        public Sach() { }
        public Sach(string maSach, string tenSach, string nxb, string donGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            NhaXB = nxb;
            DonGia = donGia;
        }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string NhaXB { get; set; }
        public string DonGia { get; set; }

    }
}
