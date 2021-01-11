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
using System.Data;
using BUS;
using DTO;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frm_TinhTien : Form
    {

        private DTO_CUser currentUserLogin;
        private DataTable tableProduct;
        private String billID;
        public frm_TinhTien(DTO_CUser currentUserLogin, DataTable tableProduct, String billID)
        {
            this.currentUserLogin = currentUserLogin;
            this.tableProduct = tableProduct;
            this.billID = billID;
            InitializeComponent();
            this.lb_total_price.Text = String.Format("{0:#,##}", this.loadTotalPrice());
                }
        private int loadTotalPrice()
        {
            int sum = 0;
            foreach(DataRow row in this.tableProduct.Rows)
            {
                sum += int.Parse(row["THANHTIEN"].ToString());
            }
            return sum;
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
            int cashBack = int.Parse(this.lb_cus_cash.Text.ToString().Replace(",", "").Trim()) - int.Parse(this.lb_total_price.Text.ToString().Replace(",", "").Trim());
            this.lb_cash_back.Text = string.Format("{0:#,##}", cashBack);
        }

        private string formatToCurrency(string num)
        {
            return String.Format("{0:#,##}", num);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.lb_cus_cash.Text.ToString().Replace(",", "").Trim()) >= int.Parse(this.lb_total_price.Text.ToString().Replace(",", "").Trim()))
            {
                try
                {
                    bool success = false;
                    DTO_Bill bill = new DTO_Bill(this.billID, this.currentUserLogin.MaNV, DateTime.Now, int.Parse(this.lb_total_price.Text.ToString().Replace(",", "").Trim()));
                    success = new BUS_Bill().insertBill(bill);
                    foreach (DataRow row in this.tableProduct.Rows)
                    {
                        DTO_BillDetail billDetail = new DTO_BillDetail(this.billID, row["MSMH"].ToString(), int.Parse(row["SOLUONG"].ToString()), int.Parse(row["THANHTIEN"].ToString()));
                        new BUS_BillDetail().insertBillDetail(billDetail);
                    }
                    DTO_Money.Sales = DTO_Money.Sales + int.Parse(this.lb_total_price.Text.ToString().Replace(",", "").Trim());
                    new frm_InHoaDon(this.billID).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Nhận thiếu tiền", "Không thể thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
    }
}
