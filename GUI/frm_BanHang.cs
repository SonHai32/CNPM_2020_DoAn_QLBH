using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_BanHang : Form
    {
        public frm_BanHang()
        {
            InitializeComponent();
            this.loadBillID();
         }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lb_current_datetime.Text =  DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
        private void loadBillID()
        {
            this.lb_bill_id.Text = "HD-" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString();
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
