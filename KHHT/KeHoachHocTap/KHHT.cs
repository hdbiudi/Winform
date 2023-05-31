using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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
    public partial class KHHT : Form
    {
        private string nganhHoc;
        private string maNganh;
        public string connect = @"Data Source=DESKTOP-O7P3F9G;Initial Catalog=QuanLyKHHT;Integrated Security=True";
        public KHHT()
        {
            InitializeComponent();
        }
        public KHHT(string nganhHoc, string maNganh)
        {
            InitializeComponent();
            this.nganhHoc = nganhHoc;
            this.maNganh = maNganh;
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

        private void btn_lietKe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            string hk = cbb_hk.Text;
            string khhtmau = "select * from KHHTMau where HKDeNghi ='" + hk + "'";
            conn.Open();
            SqlCommand htmau = new SqlCommand(khhtmau, conn);// thực hiện câu lệnh truy vấn đến SQL
            htmau.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(htmau);//lưu dữ liệu lấy dc vào đây
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_mau.DataSource = dt;
            dataGridView_mau.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_mau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        private void KHHT_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            lbl_nghanhHoc.Text = nganhHoc;
            lbl_maNganh.Text = maNganh;
            // bomon
            string boMon = "select DonVi.BoMon from DonVi where MaNganh ='" + maNganh + "'";
            conn.Open();
            SqlCommand bm= new SqlCommand();
            bm.CommandType = CommandType.Text;
            bm.CommandText = boMon;
            bm.Connection = conn;
            lbl_boMon.Text =  (string)bm.ExecuteScalar();
            // he dao tao
            string heDaoTao = "select DonVi.HeDaoTao from DonVi where MaNganh ='" + maNganh + "'";
            SqlCommand hdt = new SqlCommand();
            hdt.CommandType = CommandType.Text;
            hdt.CommandText = heDaoTao;
            hdt.Connection = conn;
            lbl_heDT.Text = (string)hdt.ExecuteScalar();
            // don vi quan ly
            string donViQuanLy = "select DonVi.DonViQuanLy from DonVi where MaNganh ='" + maNganh + "'";
            SqlCommand dvql = new SqlCommand();
            dvql.CommandType = CommandType.Text;
            dvql.CommandText = donViQuanLy;
            dvql.Connection = conn;
            lbl_donVi.Text = (string)dvql.ExecuteScalar();
            conn.Close();


        }
    }
}
