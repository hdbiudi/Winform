using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeHoachHocTap
{
    public partial class KHHTTK : Form
    {
        string connect = @"Data Source=DESKTOP-O7P3F9G;Initial Catalog=QuanLyKHHT;Integrated Security=True";
        private string user;
        public KHHTTK()
        {
            InitializeComponent();
        }
        public KHHTTK(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void KHHTTK_Load(object sender, EventArgs e)
        {
            lbl_MSSV.Text = user;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            // hoten
            string hoTen = "select SinhVien.HoTen from SinhVien where MSSV ='" + user + "'";
            SqlCommand hoten = new SqlCommand();
            hoten.CommandType = CommandType.Text;
            hoten.CommandText = hoTen;
            hoten.Connection = conn;
            lbl_hoTen.Text = (string)hoten.ExecuteScalar();
            //ma lop
        
            string lop = "select SinhVien.Lop from SinhVien where MSSV ='" + user + "'";
            SqlCommand l = new SqlCommand();
            l.CommandType = CommandType.Text;
            l.CommandText = lop;
            l.Connection = conn;
            lbl_Lop.Text = (string)l.ExecuteScalar();
            // khht
            
           
            string khht = "select * from KHHT";
            
            SqlCommand ht = new SqlCommand(khht, conn);// thực hiện câu lệnh truy vấn đến SQL
            ht.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ht);//lưu dữ liệu lấy dc vào đây
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_khht.DataSource = dt;
            dataGridView_khht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_khht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_troVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Thoát Chương Trình",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
