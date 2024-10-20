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
    public partial class DangNhap2 : Form
    {
        public DangNhap2()
        {
            InitializeComponent();
        }

        private void DangNhap2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            string username = txtUserName2.Text; // Lấy tên người dùng
            string password = txtPassWord2.Text; // Lấy mật khẩu

            // Tài khoản mẫu để kiểm tra
            string validUsername = "admin";
            string validPassword = "password123";

            if (username == validUsername && password == validPassword)
            {
                // Mở form NhanVien trong layout
                layout parentForm = (layout)this.Owner; // Lấy form cha (layout)
                parentForm.OpenChildFrom(new NhanVien()); // Gọi phương thức mở form con
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                lblCanhBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                lblCanhBao.Visible = true; // Hiển thị thông báo lỗi nếu thông tin sai
                txtPassWord2.Clear(); // Xóa mật khẩu đã nhập
            }

        }
    }
}
