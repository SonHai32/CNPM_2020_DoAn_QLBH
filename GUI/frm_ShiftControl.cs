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
    public partial class frm_ShiftControl : Form
    {
        public frm_ShiftControl()
        {
            InitializeComponent();
        }

        private void updateMoney()
        {
            int m_500K = 500000 * int.Parse(this.txt_500K.Text.ToString().Trim());
            int m_200K = 200000 * int.Parse(this.txt_200K.Text.ToString().Trim());
            int m_100K = 100000 * int.Parse(this.txt_100K.Text.ToString().Trim());
            int m_50K = 50000 * int.Parse(this.txt_50K.Text.ToString().Trim());
            int m_20K = 20000 * int.Parse(this.txt_20K.Text.ToString().Trim());
            int m_10K = 10000 * int.Parse(this.txt_10K.Text.ToString().Trim());
            int m_5K = 5000 * int.Parse(this.txt_5K.Text.ToString().Trim());
            int m_2K = 2000 * int.Parse(this.txt_2K.Text.ToString().Trim());
            int m_1K = 1000 * int.Parse(this.txt_1K.Text.ToString().Trim());
            long total = m_500K + m_200K + m_100K + m_50K + m_20K + m_10K + m_5K + m_2K + m_1K;
            this.lb_total_price_input.Text = String.Format("{0:#,##}", total);
        }
        private void textChange(object sender, EventArgs e)
        {

            if (((Guna.UI2.WinForms.Guna2TextBox)sender).Text.ToString().Trim() == "")
                return;
            try
            {
                this.updateMoney();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
