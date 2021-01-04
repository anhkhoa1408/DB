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
using System.Data.SqlClient;

namespace CSDL_APP
{
    public partial class giaodienchinh : Form
    {
        public giaodienchinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            hienthi h = new hienthi();
            h.Show();
            this.Hide();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            timkiem k = new timkiem();
            k.Show();
            this.Hide();
        }

        private void them_Click(object sender, EventArgs e)
        {
            them t = new them();
            t.Show();
            this.Hide();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            xoa x = new xoa();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capnhat c = new capnhat();
            c.Show();
            this.Hide();
        }
    }
}
