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
    public partial class hienthi : Form
    {
        public hienthi()
        {
            InitializeComponent();
        }

        private void hienthi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ANH-KHOA\SQLEXPRESS;Initial Catalog=BTL2;Integrated Security=True";
            DataTable ds = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH", con);
            dap.Fill(ds);
            dgvHienthi.DataSource = ds;
        }

        private void hienthi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            giaodienchinh gd = new giaodienchinh();
            gd.Show();
        }

        private void cbKethop_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ANH-KHOA\SQLEXPRESS;Initial Catalog=BTL2;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUBAOHANH JOIN SANPHAM ON PHIEUBAOHANH.IMEI = SANPHAM.IMEI", con);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            dap.Fill(ds);
            dgvHienthi.DataSource = ds;
            //if (cbKethop.Checked == false)
            //{
            //    SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM PHIEUBAOHANH", con);
            //    dp.Fill(ds);
            //    dgvHienthi.DataSource = ds;
            //}    
        }
    }
}
