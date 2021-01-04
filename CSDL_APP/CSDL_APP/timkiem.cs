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
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "IMEI")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH WHERE IMEI like '" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(comboBox2.Text == "Serial")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH WHERE Serial like '" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "Mã bảo hành")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH WHERE Ma_BH like '" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "Loại")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH WHERE Loai_BH like '" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "Thời hạn")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH WHERE Thoi_han_BH like '" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void timkiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }
    }
}
