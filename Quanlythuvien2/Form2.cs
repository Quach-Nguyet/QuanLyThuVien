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
        private IObjectContainer db = Db4oFactory.OpenFile("CSDL Sach");
        private IObjectSet result;
        private int i;
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
            result = db.QueryByExample(book);
            if(result.Count>0)
            {
                Sach o = (Sach)result.Next();
                Ma.Text = o.MaSach;
                Tensach.Text = o.TenSach;
                NhaXB.Text = o.NhaXB;
                Dongia.Text = o.DonGia;
                i = 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sach b1 = new Sach(Ma.Text, Tensach.Text, NhaXB.Text, Dongia.Text);
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
