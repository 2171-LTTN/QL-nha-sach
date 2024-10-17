using Guna.UI2.WinForms;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text; // Lấy tên người dùng
            string password = txtPassWord.Text; // Lấy mật khẩu

            // Tài khoản mẫu để kiểm tra
            string validUsername = "admin";
            string validPassword = "password123";

            if (username == validUsername && password == validPassword)
            {
                GiaoDien giaodien = new GiaoDien();
                giaodien.Show();
                this.Hide();    
                giaodien.FormClosed += (s, avg)  => this.Close();  
            }
            else
            {
                label3.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                label3.Visible = true; // Hiển thị thông báo lỗi nếu thông tin sai
                txtPassWord.Clear(); // Xóa mật khẩu đã nhập
            }
        }

        private void Giaodien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
