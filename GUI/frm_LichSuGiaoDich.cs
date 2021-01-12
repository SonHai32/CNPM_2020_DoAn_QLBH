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
    public partial class frm_LichSuGiaoDich : Form
    {
        public frm_LichSuGiaoDich()
        {
            InitializeComponent();
            this.loadData("", null, null);
            this.check_Date.Checked = false;
            this.dayStart.Enabled = false;
            this.dayEnd.Enabled = false;

        }

        private void grv_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        public void loadData(String value, String startAt, String endAt) {

            DataTable data = new BUS.BUS_Bill().getData(value, startAt, endAt);
            if (data != null)
                this.grv_DonHang.DataSource = data;
        }

        private void txt_search_key_TextChanged(object sender, EventArgs e)
        {
            if (this.check_Date.Checked)
                this.loadData(this.txt_search_key.Text.ToString(), this.dayStart.Value.ToString("yyyy-MM-dd"), this.dayEnd.Value.ToString("yyyy-MM-dd"));
            else
                this.loadData(this.txt_search_key.Text.ToString(), null, null);
        }

        private void check_Date_CheckedChanged(object sender, EventArgs e)
        {

            if (this.check_Date.Checked)
            {
                this.dayEnd.Enabled = true;
                this.dayStart.Enabled = true;
                this.loadData(this.txt_search_key.Text.ToString(), this.dayStart.Value.ToString("yyyy-MM-dd"), this.dayEnd.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
            this.dayStart.Enabled = false;
                this.dayEnd.Enabled = false;
                this.loadData(this.txt_search_key.Text.ToString(), null, null);
            }
        }

        private void dateValueChanged(object sender, EventArgs e)
        {
            this.loadData(this.txt_search_key.Text.ToString(), this.dayStart.Value.ToString("yyyy-MM-dd"), this.dayEnd.Value.ToString("yyyy-MM-dd"));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
