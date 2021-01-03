using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_TinhTien : Form
    {
        public frm_TinhTien()
        {
            InitializeComponent();
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            this.txt_cash_input.Focus();
        }

        private void btn_numclick_Click(object sender, EventArgs e)
        {
            String cash =  this.txt_cash_input.Text.ToString().Replace(",","").Trim() + ((Guna.UI2.WinForms.Guna2GradientTileButton)sender).Text.ToString();
            if (cash.Length > 9)
                return;
            if (int.Parse(cash) == 0)
                return; 
            long money = long.Parse(cash);
            this.txt_cash_input.Text = String.Format("{0:#,##}", money); 

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_cash_input.Text.ToString().Length <=1)
            {
                this.txt_cash_input.Text = "0";
                return;

            }
            String cash =  this.txt_cash_input.Text.ToString().Replace(",","");
            long money = long.Parse(cash.Substring(0, cash.Length-1));
           this.txt_cash_input.Text = this.formatToCurrency(money.ToString()); 
        }

        private void txt_cash_input_TextChanged(object sender, EventArgs e)
        {

            this.lb_cus_cash.Text = this.txt_cash_input.Text.ToString();
        }

        private string formatToCurrency(string num)
        {
            return String.Format("{0:#,##}", num);
        }
    }
}
