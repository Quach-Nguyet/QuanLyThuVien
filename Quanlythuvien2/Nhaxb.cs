using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien2
{
    class Nhaxb
    {
        string _tenXB;

        public string TenXB
        {
            get { return _tenXB; }
            set { _tenXB = value; }
        }
        string _diachi;

        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        string _sdt;

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        //phương thức khởi tạo
        public Nhaxb()
        {

        }
        public Nhaxb(string tenXB,string diachi, string sdt, string email)
        {
            _tenXB = tenXB;
            _diachi = diachi;
            _sdt = sdt;
            _email = email;

        }
    }
}
