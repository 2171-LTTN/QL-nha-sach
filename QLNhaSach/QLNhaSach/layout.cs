using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class layout : Form
    {
        public layout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (currentFromChild == null)
            {
                currentFromChild.Close();
            }
        }

        private void layout_Load(object sender, EventArgs e)
        {
            DangNhap loginForm = new DangNhap();
            loginForm.Owner = this; // Đặt form cha cho DangNhap2
            OpenChildFrom(loginForm); // Mở form đăng nhập
            txtHome.Text = btnNV.Text; // Cập nhật txtHome nếu cần

        }
        private Form currentFromChild;
        public void OpenChildFrom(Form ChildFrom)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
           currentFromChild = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildFrom);
            panel_body.Tag = ChildFrom;
            ChildFrom.BringToFront();
            ChildFrom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GiaoDien());
            txtHome.Text = btnSach.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new ChiTietHoaDon());
            txtHome.Text = btnSach.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new HoaDon ());
            txtHome.Text = btnSach.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DangNhap2 loginForm = new DangNhap2();
            loginForm.Owner = this; // Đặt form cha cho DangNhap2
            OpenChildFrom(loginForm); // Mở form đăng nhập
            txtHome.Text = btnNV.Text; // Cập nhật txtHome nếu cần
        }

        private void txtHome_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
