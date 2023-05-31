using Microsoft.VisualBasic.ApplicationServices;
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
    
    public partial class NhapKHHT : Form
    {
        public string connect = @"Data Source=DESKTOP-O7P3F9G;Initial Catalog=QuanLyKHHT;Integrated Security=True";
        private string user;
        public NhapKHHT()
        {
            InitializeComponent();
        }
        public NhapKHHT(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void NhapKHHT_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            try
            {
                lbl_maso.Text = user;
                conn.Open();
                string hoTen = "select SinhVien.HoTen from SinhVien where MSSV ='" + user + "'";
                SqlCommand hoten = new SqlCommand();
                hoten.CommandType = CommandType.Text;
                hoten.CommandText = hoTen;
                hoten.Connection = conn;
                lbl_hoTen.Text = (string)hoten.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string maHP_tk = txt_maHP_timKiem.Text;
            SqlConnection conn = new SqlConnection(connect);
            try
            { 
                conn.Open();
                string maHocPhan = "select KHHTMau.MaHocPhan from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                SqlCommand mHP = new SqlCommand();
                mHP.CommandType = CommandType.Text;
                mHP.CommandText = maHocPhan;
                mHP.Connection = conn;
                lbl_maHP.Text = (string)mHP.ExecuteScalar();
                //ten hoc phan lbl_tenHP
                string tenHocPhan = "select KHHTMau.TenHocPhan from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                SqlCommand tHP = new SqlCommand();
                tHP.CommandType = CommandType.Text;
                tHP.CommandText = tenHocPhan;
                tHP.Connection = conn;
                lbl_tenHP.Text = (string)tHP.ExecuteScalar();
                //so tin chi lbl_tinChi
                string soTinChi = "select KHHTMau.SoTinChi from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                SqlCommand stc = new SqlCommand();
                stc.CommandType = CommandType.Text;
                stc.CommandText = soTinChi;
                stc.Connection = conn;
                lbl_tinChi.Text = (string)stc.ExecuteScalar();
                 // so tiet ly thuyet  lbl_soTietLT
                 string tietLT = "select KHHTMau.SoTietLT from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                 SqlCommand tLT = new SqlCommand();
                 tLT.CommandType = CommandType.Text;
                 tLT.CommandText = tietLT;
                 tLT.Connection = conn;
                 lbl_soTietLT.Text = (string)tLT.ExecuteScalar();
                 // so tiet thuc hanh lbl_soTietTH
                 string tietTH = "select KHHTMau.SoTietTH from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                 SqlCommand tTH = new SqlCommand();
                 tTH.CommandType = CommandType.Text;
                 tTH.CommandText = tietTH;
                 tTH.Connection = conn;
                 lbl_soTietTH.Text = (string)tTH.ExecuteScalar();
                 //tien quyet lbl_tienQuyet
                 string tienQ = "select KHHTMau.HocPhanTienQuyet from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                 SqlCommand tq = new SqlCommand();
                 tq.CommandType = CommandType.Text;
                 tq.CommandText = tienQ;
                 tq.Connection = conn;
                 lbl_tienQuyet.Text = (string)tq.ExecuteScalar();
                 // hocj ky mo lbl_hkMo
                 string hkMo = "select KHHTMau.HKMo from KHHTMau where MaHocPhan ='" + maHP_tk + "'";
                 SqlCommand khm = new SqlCommand();
                 khm.CommandType = CommandType.Text;
                 khm.CommandText = hkMo;
                 khm.Connection = conn;
                lbl_hockymo.Text = (string)khm.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Thoát Chương Trình",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btn_troLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string query_khht = "insert into KHHT (MaHocPhan,TenHocPhan,SoTinChi,NamHoc,HocKy) values(@MaHP,@TenHP,@SoTC,@Nam,@HK)";
            SqlCommand cmd_insert = new SqlCommand(query_khht, conn);
            cmd_insert.Parameters.AddWithValue("@MaHP", lbl_maHP.Text);
            cmd_insert.Parameters.AddWithValue("@TenHP", lbl_tenHP.Text);
            cmd_insert.Parameters.AddWithValue("@SoTC", lbl_tinChi.Text);
            cmd_insert.Parameters.AddWithValue("@Nam", cbb_NamHoc.Text);
            cmd_insert.Parameters.AddWithValue("@HK", cbb_hocKy.Text);

            string maHP = lbl_maHP.Text;              
            string query_maHP = "select KHHT.MaHocPhan from KHHT where MaHocPhan ='" + maHP + "'";
            SqlCommand cmd = new SqlCommand(query_maHP, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                MessageBox.Show("Mã học phần đã có trong Kế Hoạch Học Tập không thể thêm", "Thông Báo");
                conn.Close();
            }
            else
            {
                dta.Close();
                cmd_insert.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maHP = lbl_maHP.Text;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string query_delkhht = "delete from KHHT where MaHocPhan ='" + maHP + "'";
            SqlCommand cmd_delete = new SqlCommand(query_delkhht, conn);
            
            string query_maHP = "select KHHT.MaHocPhan from KHHT where MaHocPhan ='" + maHP + "'";
            SqlCommand cmd = new SqlCommand(query_maHP, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                dta.Close();
                cmd_delete.ExecuteNonQuery();
                MessageBox.Show("Mã học phần đã được xóa", "Thông Báo");
                conn.Close();
            }
            else
            {

                MessageBox.Show("Mã Học Phần không có trong KHHT!");
            }
        }
    }
}
