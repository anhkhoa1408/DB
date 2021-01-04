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
    public partial class xoa : Form
    {
        public xoa()
        {
            InitializeComponent();
        }

        private void xoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (comboBox1.Text == "Imei")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                    SqlDataAdapter dap = new SqlDataAdapter("DELETE FROM PHIEUBAOHANH WHERE IMEI like '" + textBox1.Text + "%'", con);
                    //SqlDataAdapter test = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH", con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Serial")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                    SqlDataAdapter dap = new SqlDataAdapter("DELETE FROM PHIEUBAOHANH WHERE Serial like '" + textBox1.Text + "%'", con);
                    //SqlDataAdapter test = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH", con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Mã bảo hành")
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source = ANH-KHOA\SQLEXPRESS; Initial Catalog = BTL2; Integrated Security = True";
                    SqlDataAdapter dap = new SqlDataAdapter("DELETE FROM PHIEUBAOHANH WHERE Ma_BH like '" + textBox1.Text + "%'", con);
                    //SqlDataAdapter test = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH", con);
                    DataTable dt = new DataTable();
                    dap.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }
                clearInsert();
            }
        }
        private void clearInsert()
        {
            textBox1.Text = "";
        }

        private void xoa_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }
    }
}
