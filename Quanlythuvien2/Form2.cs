using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien2
{
    public partial class Form2 : Form
    {
        // làm gì có cái cú pháp nào khai báo biến mà k có propertype???
     // Does not exist in curent context => tức là không tồn tại class này trong cùng 1 context (project).
     // xem n có gợi ý sửa k
        private IObjectContainer db = Db4oFactory.OpenFile("CSDL Sach"); // (0) có phải cái này k => thế thì em phải khai báo db ơ đâu cho đúng nào?
                                                                         // "trong phạm vi của hàm laydl() hoặc lớp cha của nó" => hỉu hông
        int i = 0;
        private IObjectSet result;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            laydl();
        }
        private void laydl()
        {
            Sach book = new Sach();
            // làm gì có cái cú pháp nào khai báo biến mà k có propertype???
            // ví dụ em khai báo 1 biến 
            // int x= 1
            // chứ làm gì có cái cú pháp 
            // x = 1. mà x chưa được định nghĩa
            // hỉu hông ...
            // còn 1 lỗi thứ 2.
            // cái db có tồn tại trong phạm vi của hàm laydl() hoặc lớp cha của nó k??? => ... chưa tao
            // rùi nếu tạo thì nó là cái gì nào? => /...là dữ liệu lấy ra từ db40 ý (0)
            result = db.QueryByExample(book);
            if(result.Count>0)
            {
                Sach o = (Sach)result.Next();
                // lại là lỗi k tồn tại textBox1
                Ma.Text = o.MaSach;
                Tensach.Text = o.TenSach;
                NhaXB.Text = o.NhaXB;
                Dongia.Text = o.DonGia;
                i = 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // không có contructor nào truyền vào đống param này cả
            // sau khi tạo constructor rồi thì có thể khởi tạo 1 object Sach bằng constructorr như này
            Sach b1 = new Sach(Ma.Text, Tensach.Text, NhaXB.Text, Dongia.Text);
            // a dạy 1 cách khác mà k cần constructor
            //Sach b2 = new Sach()
            //{
            //    MaSach = Ma.Text,
            //    TenSach = Tensach.Text,
            //    NhaXB = NhaXB.Text,
            //    DonGia = Dongia.Text
            //};
            db.Store(b1);
            MessageBox.Show("Thêm thông tin thành công");
            laydl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == result.Count)
                return;
            Sach o = (Sach)result.Next();
                Ma.Text = o.MaSach;
                Tensach.Text = o.TenSach;
                NhaXB.Text = o.NhaXB;
                Dongia.Text = o.DonGia;
            i = i + 1;
        }
    }
}
