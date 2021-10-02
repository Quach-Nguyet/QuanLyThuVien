using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien2
{
    // class phải public thì class khác ms đọc đc
    public class Sach
    {

        //phương thức khởi tạo
        // constructor thì nên đặt trên đầu
        public Sach()
        {

        }
        // cách khơi tạo 1 object thông thường
        public Sach(string maSach, string tenSach, string nxb, string donGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            NhaXB = nxb;
            // cách viết tên biến như này đi làm sẽ bị leader chửi nhé. DonGia chứ k được để Dongia
            DonGia = donGia;
        }

        //string Masach;
        //public string _MaSach
        //{
        //    get { return Masach; }
        //    set { Masach = value; }
        //}
        public string MaSach { get; set; }

        //string Tensach;

        //public string _TenSach
        //{
        //    get { return Tensach; }
        //    set { Tensach = value; }
        //}
        public string TenSach { get; set; }
        //string NhaXB;

        //public string _NhaXB
        //{
        //    get { return NhaXB; }
        //    set { NhaXB = value; }
        //}

        //Đây là cách viết tắt. gõ prop xong bấm tab trên bàn phím
        public string NhaXB { get; set; }

        // get, set đâu
        // a dạy cách viết tắt get set nhé
        public string DonGia { get; set; }

    }
}
