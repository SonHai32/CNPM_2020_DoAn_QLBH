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

        private int option;
        private DTO.DTO_CUser loginedUser;
        public static DTO.DTO_WorkShift WORK_SHIFT = null;
        //option = 0 => Mở ca
        //option = 1 => Đóng ca
        //option = 2 => Rút tiền


        public frm_ShiftControl(int option, DTO.DTO_CUser loginedUser)
        {
            this.option = option;
            this.loginedUser = loginedUser;
            InitializeComponent();
            this.loadForm();
            if (option == 1)
                this.updateMoney();
        }

        public void loadForm()
        {
            if(option ==0)
            {
                this.lb_header.Text = "MỞ CA";
                this.lb_chenh_lech.Visible = false;
                this.lb_chenh_lech_price.Visible = false;
                this.btn_submit.Text = "MỞ CA";
                
            }else if(option == 1)
            {
                this.lb_header.Text = "ĐÓNG CA";
                this.lb_chenh_lech.Visible = true;
                this.lb_chenh_lech_price.Visible = true;
                this.btn_submit.Text = "ĐÓNG CA";



            }
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
            int totalInputMoney = m_500K + m_200K + m_100K + m_50K + m_20K + m_10K + m_5K + m_2K + m_1K;
            if (this.option == 1)
            {
                long totalMoney = DTO.DTO_Money.Money + DTO.DTO_Money.Sales;
                this.lb_chenh_lech_price.Text = String.Format("{0:#,##}", totalInputMoney - totalMoney);
            }
            this.lb_total_price_input.Text = String.Format("{0:#,##}", totalInputMoney);
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(option == 0)
            {
                DTO.DTO_WorkShift workShift = new DTO.DTO_WorkShift("CL-" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString(), loginedUser.MaNV, DateTime.Now, float.Parse(DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString()), 0);
                try
                {
                    DTO.DTO_Money.Status1 = true;
                    DTO.DTO_Money.NumOf500K = int.Parse(this.txt_500K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf200K = int.Parse(this.txt_200K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf100K= int.Parse(this.txt_100K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf50K = int.Parse(this.txt_50K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf20K = int.Parse(this.txt_20K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf10K = int.Parse(this.txt_10K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf5K = int.Parse(this.txt_5K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf2K = int.Parse(this.txt_1K.Text.ToString().Trim());
                    DTO.DTO_Money.NumOf1K = int.Parse(this.txt_1K.Text.ToString().Trim());
                    long moneyInputTotal = long.Parse(this.lb_total_price_input.Text.ToString().Replace(",", "").Trim());

                    if(moneyInputTotal >= 3000000)
                    {
                        DTO.DTO_Money.Status1 = true;
                        DTO.DTO_Money.Money = moneyInputTotal;
                        new BUS.BUS_WorkShift().insertWorkShift(workShift);
                        frmHethong.workShiftID = workShift.WorkShiftID;
                        DialogResult result =  MessageBox.Show("MỞ CA THÀNH CÔNG", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                            this.Dispose();
                    }
                    else
                        MessageBox.Show("Số tiền mở ca cần phải từ 3 triệu trở lên", "MỞ CA THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }else if(option ==1){
                DTO.DTO_Money.Status1 = false;
                long sales = DTO.DTO_Money.Sales + DTO.DTO_Money.Money;
                long chenhLech = long.Parse(this.lb_chenh_lech_price.Text.ToString().Replace(",", "").Trim());

                try
                {
                    string hour = DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString();

                    new BUS.BUS_WorkShift().updateWorkShift(frmHethong.workShiftID, float.Parse(hour));
                    new BUS.BUS_WorkShift().insertWorkShiftDetail(frmHethong.workShiftID, DTO.DTO_Money.Money, DTO.DTO_Money.Sales, chenhLech);
                    DialogResult result =  MessageBox.Show("Đóng CA THÀNH CÔNG", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                            this.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void text_leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            if (textBox.Text.ToString().Trim() == "")
            {
                textBox.Text = "0";
                this.updateMoney();
            }
        }
    }
}
