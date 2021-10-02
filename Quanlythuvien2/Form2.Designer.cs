
namespace Quanlythuvien2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Masach = new System.Windows.Forms.MaskedTextBox();
            this.Tensach = new System.Windows.Forms.MaskedTextBox();
            this.NhaXB = new System.Windows.Forms.MaskedTextBox();
            this.Dongia = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sach = new System.Windows.Forms.MaskedTextBox();
            this.Ma = new System.Windows.Forms.MaskedTextBox();
            this.XB = new System.Windows.Forms.MaskedTextBox();
            this.Gia = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gia);
            this.groupBox1.Controls.Add(this.XB);
            this.groupBox1.Controls.Add(this.Ma);
            this.groupBox1.Controls.Add(this.Sach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng sách hiển thị";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Dongia);
            this.groupBox2.Controls.Add(this.NhaXB);
            this.groupBox2.Controls.Add(this.Tensach);
            this.groupBox2.Controls.Add(this.Masach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // Masach
            // 
            this.Masach.Location = new System.Drawing.Point(94, 36);
            this.Masach.Name = "Masach";
            this.Masach.Size = new System.Drawing.Size(215, 22);
            this.Masach.TabIndex = 0;
            //nó không tồn tại thì vứt n đi là đc => rồi lưu lại
            //this.Masach.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Tensach
            // 
            this.Tensach.Location = new System.Drawing.Point(94, 89);
            this.Tensach.Name = "Tensach";
            this.Tensach.Size = new System.Drawing.Size(215, 22);
            this.Tensach.TabIndex = 4;
            // 
            // NhaXB
            // 
            this.NhaXB.Location = new System.Drawing.Point(519, 36);
            this.NhaXB.Name = "NhaXB";
            this.NhaXB.Size = new System.Drawing.Size(239, 22);
            this.NhaXB.TabIndex = 5;
            // 
            // Dongia
            // 
            this.Dongia.Location = new System.Drawing.Point(521, 91);
            this.Dongia.Name = "Dongia";
            this.Dongia.Size = new System.Drawing.Size(237, 22);
            this.Dongia.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next >>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhà Xuất Bản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giá Bán:";
            // 
            // Sach
            // 
            this.Sach.Location = new System.Drawing.Point(116, 99);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(215, 22);
            this.Sach.TabIndex = 5;
            // 
            // Ma
            // 
            this.Ma.Location = new System.Drawing.Point(116, 59);
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(212, 22);
            this.Ma.TabIndex = 6;
            // 
            // XB
            // 
            this.XB.Location = new System.Drawing.Point(548, 54);
            this.XB.Name = "XB";
            this.XB.Size = new System.Drawing.Size(193, 22);
            this.XB.TabIndex = 7;
            // 
            // Gia
            // 
            this.Gia.Location = new System.Drawing.Point(548, 108);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(193, 22);
            this.Gia.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Masach;
        private System.Windows.Forms.MaskedTextBox Tensach;
        private System.Windows.Forms.MaskedTextBox Dongia;
        private System.Windows.Forms.MaskedTextBox NhaXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Gia;
        private System.Windows.Forms.MaskedTextBox XB;
        private System.Windows.Forms.MaskedTextBox Ma;
        private System.Windows.Forms.MaskedTextBox Sach;
    }
}