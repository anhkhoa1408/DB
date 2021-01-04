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


namespace CSDL_APP
{
    public partial class capnhat : Form
    {
        public capnhat()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
            string sql = "";
            if (con.State != ConnectionState.Open)
                con.Open();
            if (txtThoihan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập vào thời hạn bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThoihan.Focus();
                return;
            }
            
            if (txtLoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập vào loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoai.Focus();
                return;
            }
            //sql = "UPDATE PHIEUBAOHANH SET Ma_BH=N'" + txtMa.Text.Trim().ToString() +
            //        "',Thoi_han_BH=N'" + txtThoihan.Text.Trim().ToString() +
            //        "',Ngay_BD='" + dtpNgayBD.Value.Date + 
            //        "',Loai_BH='" + txtLoai.Text.Trim().ToString() +
            //        "' WHERE IMEI=N'" + txtImei.Text + "'";
            if (cbCapnhat.Text == "IMEI")
            {
                if(txtTukhoa.Text.Trim()=="")
                {
                    MessageBox.Show("Bạn phải nhập vào Imei", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTukhoa.Focus();
                    return;
                }    
                SqlCommand cmd = new SqlCommand("UPDATE PHIEUBAOHANH SET Thoi_han_BH = @thoihan, Ngay_BD = @nbd, Loai_BH = @loai WHERE IMEI = @imei", con);
                //cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                cmd.Parameters.AddWithValue("@thoihan", txtThoihan.Text);
                cmd.Parameters.AddWithValue("@nbd", dtpNgayBD.Value.Date);
                cmd.Parameters.AddWithValue("@loai", txtLoai.Text);
                cmd.Parameters.AddWithValue("@imei", txtTukhoa.Text);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                MessageBox.Show("Thành công");
            }
            else if (cbCapnhat.Text == "Mã bảo hành")
            {
                if (txtTukhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập vào mã bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTukhoa.Focus();
                    return;
                }
                SqlCommand cmd = new SqlCommand("UPDATE PHIEUBAOHANH SET Thoi_han_BH = @thoihan, Ngay_BD = @nbd, Loai_BH = @loai WHERE Ma_BH = @ma", con);
                cmd.Parameters.AddWithValue("@ma", txtTukhoa.Text);
                cmd.Parameters.AddWithValue("@thoihan", txtThoihan.Text);
                cmd.Parameters.AddWithValue("@nbd", dtpNgayBD.Value.Date);
                cmd.Parameters.AddWithValue("@loai", txtLoai.Text);
                //cmd.Parameters.AddWithValue("@imei", txtImei.Text);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                MessageBox.Show("Thành công");
            }
        }
        private void clearInsert()
        {
            txtTukhoa.Text = "";
            txtThoihan.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            //txtImei.Text = "";
            txtLoai.Text = "";
        }

        private void capnhat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            clearInsert();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCapnhat.Text == "IMEI")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUBAOHANH WHERE IMEI = @imei", con);
                cmd.Parameters.AddWithValue("@imei", txtTukhoa.Text);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dgvChitiet.DataSource = dt;
            }
            else if (cbCapnhat.Text == "Mã bảo hành")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUBAOHANH WHERE Ma_BH = @ma", con);
                cmd.Parameters.AddWithValue("@ma", txtTukhoa.Text);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dgvChitiet.DataSource = dt;
            }
        }
    }
}
