using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace Quanlythuvien2
{
    public partial class Form1 : Form
    {
        IObjectContainer db;
        IObjectSet result;
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tạo hoặc mở CSDL đã có
            db = Db4oFactory.OpenFile("csdlqlthuvien");
            //lấy dữ liệu trong cSDL nếu có
            laydl();
        }
        private void laydl()
        {
            //Tạo ra một mẫu nhà xb để truy vấn theo
            Nhaxb temp = new Nhaxb();
            result = db.QueryByExample(temp);
            //không có đối tượng nào thì sao
            if(result.Count>0)
            {
                Nhaxb o = (Nhaxb)result.Next();
                textBox1.Text = o.TenXB;
                textBox2.Text = o.Diachi;
                textBox3.Text = o.Sdt;
                textBox4.Text = o.Email;
                i = 1;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Nhaxb nx1 = new Nhaxb(txten.Text, txtdiachi.Text, txtsdt.Text, txtemail.Text);
            db.Store(nx1);
            MessageBox.Show("Thêm thông tin thành công");
            laydl();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (i == result.Count)
                return;
            Nhaxb o = (Nhaxb)result.Next();
            textBox1.Text = o.TenXB;
            textBox2.Text = o.Diachi;
            textBox3.Text = o.Sdt;
            textBox4.Text = o.Email;
            i = i + 1;
        }
    }
}
