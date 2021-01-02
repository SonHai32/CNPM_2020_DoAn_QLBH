using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            this.cbGender.SelectedIndex = 0;
            this.loadCusList();
        }
        private void loadCusList()
        {
            this.grvCustomer.DataSource = new BUS_CCustomer().getCusList("SELECT * FROM KHACHHANG");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String cusID = this.txtCusID.Text;
            String cusName = this.txtCusName.Text;
            String cusAddr = this.txtCusAddr.Text;
            String cusGender = this.cbGender.SelectedItem.ToString();
            String cusPhone = this.txtCusPhone.Text;

            if (isValid(cusID, cusName, cusAddr, cusPhone))
            {
                DTO_CCustomer customer = new DTO_CCustomer(cusID, cusName, cusAddr, cusPhone, cusGender);

                new BUS_CCustomer().addCustomer(customer); 
                this.loadCusList();
            }
        }

        private bool isValid(string cusID, string cusName, string cusAddr, string cusPhone)
        {
            bool valid = false;
            if (!isNull(cusID))
                valid = true;
            else
                MessageBox.Show("Bạn chưa nhập id khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!isNull(cusName))
                valid = true;
            else
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!isNull(cusAddr))
                valid = true;
            else
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!isNull(cusPhone))
                valid = true;
            else
                MessageBox.Show("Bạn chưa nhập SDT khách hàng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return valid;
        }

        private bool isNull(string value)
        {
            return value == "";
        }
    }
}
