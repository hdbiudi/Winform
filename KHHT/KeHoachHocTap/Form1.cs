using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KeHoachHocTap
{
    public partial class Login : Form
    {


        string strConnectionString = @"Data Source=DESKTOP-O7P3F9G;Initial Catalog=QuanLyKHHT;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            try
            {
                conn.Open();
                string mssv = txt_UserName.Text;
                string mk = txt_PassWord.Text;
                string sql = "select *from SinhVien where MSSV ='" + mssv + "' and MatKhau = '" + mk + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();

                if(dta.Read() == true) {
                    TableManager f = new TableManager(txt_UserName.Text);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }else
                {
                    MessageBox.Show("Xin Lỗi MSSV Hoặc Mật Khẩu Không Khớp, Xin Lòng Nhập Lại!","Đăng Nhập Thất Bại");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Thoát Chương Trình",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
           
        }
    }
}