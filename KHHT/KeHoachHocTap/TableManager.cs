using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Data.Common;

namespace KeHoachHocTap
{
    public partial class TableManager : Form
    {
        private string user;
        string MaNganh;
        public TableManager()
        {
            InitializeComponent();
        }
        public TableManager( string user )
        {
            InitializeComponent();
            this.user = user;
        }

        private void TableManager_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-O7P3F9G;Initial Catalog=QuanLyKHHT;Integrated Security=True");
            try
            {
                lbl_MSSV.Text = user;
                conn.Open();
                // hoten
                string hoTen = "select SinhVien.HoTen from SinhVien where MSSV ='" + user + "'";
                SqlCommand hoten = new SqlCommand();
                hoten.CommandType = CommandType.Text;
                hoten.CommandText = hoTen;
                hoten.Connection = conn;
                lbl_HoTen.Text = (string)hoten.ExecuteScalar();
                // gioi tinh
                string gioiTinh = "select SinhVien.GioiTinh from SinhVien where MSSV ='" + user + "'";
                SqlCommand gt = new SqlCommand();
                gt.CommandType = CommandType.Text;
                gt.CommandText = gioiTinh;
                gt.Connection = conn;
                lbl_GioiTinh.Text = (String)gt.ExecuteScalar();

                //lop
                string lop = "select SinhVien.Lop from SinhVien where MSSV ='" + user + "'";
                SqlCommand l = new SqlCommand();
                l.CommandType = CommandType.Text;
                l.CommandText = lop;
                l.Connection = conn;
                lbl_Lop.Text = (string)l.ExecuteScalar();
                //nganh hoc
                string nganhHoc = "select SinhVien.Nganhhoc from SinhVien where MSSV ='" + user + "'";
                SqlCommand nh = new SqlCommand();
                nh.CommandType = CommandType.Text;
                nh.CommandText = nganhHoc;
                nh.Connection = conn;
                lbl_NganhHoc.Text = (string)nh.ExecuteScalar();
                // khoa hoc
                string khoaHoc = "select SinhVien.KhoaHoc from SinhVien where MSSV ='" + user + "'";
                SqlCommand kh = new SqlCommand();
                kh.CommandType = CommandType.Text;
                kh.CommandText = khoaHoc;
                kh.Connection = conn;
                lbl_KhoaHoc.Text = (string)kh.ExecuteScalar();
                // khoa
                string khoa = "select SinhVien.Khoa from SinhVien where MSSV ='" + user + "'";
                SqlCommand k = new SqlCommand();
                k.CommandType = CommandType.Text;
                k.CommandText = khoa;
                k.Connection = conn;
                lbl_Khoa.Text = (string)k.ExecuteScalar();
                // thuoc
                string thuoc = "select SinhVien.Thuoc from SinhVien where MSSV ='" + user + "'";
                SqlCommand t = new SqlCommand();
                t.CommandType = CommandType.Text;
                t.CommandText = thuoc;
                t.Connection = conn;
                lbl_Thuoc.Text = (string)t.ExecuteScalar();
                //ma nganh
                string maNganh = "select SinhVien.MaNganh from SinhVien where MSSV ='" + user + "'";
                SqlCommand mn = new SqlCommand();
                mn.CommandType = CommandType.Text;
                mn.CommandText = maNganh;
                mn.Connection = conn;
                MaNganh = (string)mn.ExecuteScalar();
                conn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }

        }

        private void btn_KHHTmau_Click(object sender, EventArgs e)
        {
            KHHT f = new KHHT(lbl_NganhHoc.Text, MaNganh);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btn_capNhatKHHT_Click(object sender, EventArgs e)
        {
            NhapKHHT n = new NhapKHHT(user);
            this.Hide();
            n.ShowDialog();
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Thoát Chương Trình",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btn_xemKHHT_Click(object sender, EventArgs e)
        {
            KHHTTK n = new KHHTTK(user);
            this.Hide();
            n.ShowDialog();
            this.Show();
        }

        private void btn_goiY_Click(object sender, EventArgs e)
        {
            GoiYHocPhan f = new GoiYHocPhan(lbl_NganhHoc.Text, MaNganh);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
