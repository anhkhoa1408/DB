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
    public partial class them : Form
    {
        public them()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
            string sql = "";
            if (con.State != ConnectionState.Open)
                con.Open();
            if (txtMa.Text.Trim() == "")
            {
                errChiTiet.SetError(txtMa, "Bạn không để trống mã bảo hành này!");
                return;
            }
            else
            {
                sql = "SELECT Count(*) FROM PHIEUBAOHANH WHERE Ma_BH ='" + txtMa.Text + "'";
                cmd = new SqlCommand(sql, con);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    errChiTiet.SetError(txtMa, "Mã bảo hành đã tồn tại");
                    return;
                }
                errChiTiet.Clear();
            }
            if (txtThoihan.Text.Trim() == "")
            {
                errChiTiet.SetError(txtThoihan, "Bạn không thể để trống thời hạn bảo hành!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (dtpNgayBD.Text.Trim() == "")
            {
                errChiTiet.SetError(dtpNgayBD, "Bạn không thể để trống ngày bắt đầu bảo hành!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            if (txtImei.Text.Trim() == "")
            {
                errChiTiet.SetError(txtImei, "Bạn không thể để trống Imei!");
                return;
            }
            else
            {
                errChiTiet.Clear();
                sql = "SELECT Count(*) FROM SANPHAM WHERE IMEI ='" + txtImei.Text + "'";
                SqlCommand test = new SqlCommand(sql, con);
                int val = (int)test.ExecuteScalar();
                if (val == 0)
                {
                    MessageBox.Show("Sản phẩm không tồn tại, không thể thêm phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtImei.Focus();
                    return;
                }
            }
            if (txtSerial.Text.Trim() == "")
            {
                errChiTiet.SetError(txtSerial, "Bạn không thể để trống Serial!");
                return;
            }
            else
            {
                errChiTiet.Clear();
                sql = "SELECT Count(*) FROM SANPHAM WHERE Serial ='" + txtImei.Text + "'";
                SqlCommand test = new SqlCommand(sql, con);
                int val = (int)test.ExecuteScalar();
                if (val == 0)
                {
                    MessageBox.Show("Sản phẩm không tồn tại, không thể thêm phiếu bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtImei.Focus();
                    return;
                }
            }
            if (dtpNgayBD.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgayBD, "Ngày bắt đầu không hợp lệ!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }

            SqlCommand insert = new SqlCommand("INSERT INTO PHIEUBAOHANH(Ma_BH, Thoi_han_bh, Ngay_BD, IMEI, Serial, Loai_BH) VALUES(@m,@th,@nbd,@imei,@ser,@loai)",con);
            insert.Parameters.AddWithValue("@m", txtMa.Text);
            insert.Parameters.AddWithValue("@th", txtThoihan.Text);
            insert.Parameters.AddWithValue("@nbd", dtpNgayBD.Value.Date);
            insert.Parameters.AddWithValue("@imei", txtImei.Text);
            insert.Parameters.AddWithValue("@ser", txtSerial.Text);
            insert.Parameters.AddWithValue("@loai", txtLoai.Text);
            SqlDataAdapter dap = new SqlDataAdapter(insert);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            MessageBox.Show("Thành công");
        }

        private void clearInsert()
        {
            txtMa.Text = "";
            txtThoihan.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            txtImei.Text = "";
            txtSerial.Text = "";
            txtLoai.Text = "";
        }

        private void them_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearInsert();
        }
    }
}
