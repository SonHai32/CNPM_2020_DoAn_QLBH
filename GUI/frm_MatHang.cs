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
    public partial class frm_MatHang : Form
    {
        public frm_MatHang()
        {
            InitializeComponent();
            this.loadData("");
        }

        private bool isDataInsert = false;

        public void loadData(String searchValue)
        {
            DataTable data = new BUS.BUS_Product().findProducts(searchValue);
            if (data != null)
                this.grv_mat_hang.DataSource = data;
        }

        private void txt_search_key_TextChanged(object sender, EventArgs e)
        {
            this.loadData(this.txt_search_key.Text.ToString());
        }

        private void frm_MatHang_Load(object sender, EventArgs e)
        {

        }

        private void grv_mat_hang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.grv_mat_hang.Refresh();
            if(e.RowIndex >= 0)
            {
                DTO.DTO_Product product = new DTO.DTO_Product();
                product.ProductID = this.grv_mat_hang.Rows[e.RowIndex].Cells["MSMH"].Value.ToString();
                product.ProductName = this.grv_mat_hang.Rows[e.RowIndex].Cells["TENMH"].Value.ToString();
                product.ProductPrice = int.Parse(this.grv_mat_hang.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString());
                product.ProductAmount = int.Parse(this.grv_mat_hang.Rows[e.RowIndex].Cells["SL_TON"].Value.ToString());
                product.ProductUnit = this.grv_mat_hang.Rows[e.RowIndex].Cells["DONVITINH"].Value.ToString();

                this.loadInputForm(product, false);
                this.isDataInsert = true;
            }
        }

        public void loadInputForm(DTO.DTO_Product product, bool isNew)
        {
            this.txt_product_id.Text = product.ProductID;
            this.txt_product_name.Text = product.ProductName;
            this.txt_product_price.Text = isNew ? "" : product.ProductPrice.ToString();
            this.txt_product_unit.Text = product.ProductUnit;
            this.txt_product_amount.Text = isNew ? "" : product.ProductAmount.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.loadInputForm(new DTO.DTO_Product("","", 0, 0, ""), true);
            this.isDataInsert = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int currentDataRowIndex = this.grv_mat_hang.CurrentCell.RowIndex;
            if(currentDataRowIndex >= 0 && isDataInsert)
            {

                DialogResult alertMessage = MessageBox.Show("BẠN CÓ MUỐN XÓA " + this.getProductInput().ProductName + "", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == alertMessage)
                {
                    try
                    {
                       if(new BUS.BUS_Product().deleteProduct(this.getProductInput().ProductID))
                       {
                            this.loadInputForm(new DTO.DTO_Product("", "", 0, 0, ""), true);
                            this.loadData("");
                            MessageBox.Show("XÓA THÀNH CÔNG", "THÀNH CỐNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
         

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    }
            }
            else
                MessageBox.Show("KHÔNG CÓ SẢN PHẨM NÀO ĐỂ XÓA", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private DTO.DTO_Product getProductInput()
        {
            DTO.DTO_Product product = new DTO.DTO_Product();
            product.ProductID = this.txt_product_id.Text;
            product.ProductName = this.txt_product_name.Text;
            product.ProductAmount = int.Parse(this.txt_product_amount.Text.ToString());
            product.ProductPrice = int.Parse(this.txt_product_price.Text.ToString());
            product.ProductUnit = this.txt_product_unit.Text;

            return product;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!isDataInsert)
            {
                
                try
                {
                    if (new BUS.BUS_Product().insertProduct(this.getProductInput()))
                    {
                        this.loadInputForm(new DTO.DTO_Product("", "", 0, 0, ""), true);
                        this.loadData("");
                        MessageBox.Show("THÊM HÀNG HÓA THÀNH CÔNG", "THÀNH CỐNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("THÊM HÀNG HÓA THẤT BẠI", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void grv_mat_hang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
