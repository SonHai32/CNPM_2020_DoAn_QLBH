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
    public partial class frm_BanHang : Form
    {
        private DataTable tbProductBuy;
        private DTO_CUser currentLoginUser;
        public frm_BanHang(DTO_CUser currentLoginUser)
        {
            this.currentLoginUser = currentLoginUser;
            InitializeComponent();

            this.loadBillID();
            this.loadGrvProductSearch("");
            this.tbProductBuy = new DataTable();
            this.tbProductBuy.Columns.Add("MSMH");
            this.tbProductBuy.Columns.Add("TENMH");
            this.tbProductBuy.Columns.Add("SOLUONG");
            this.tbProductBuy.Columns.Add("THANHTIEN");
           
        }

        public void loadGrvProductSearch(string key)
        {
            this.grv_products_search.DataSource = new BUS_Product().findProducts(key);
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

        private void txt_search_key_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.txt_search_key.Text);
            loadGrvProductSearch(this.txt_search_key.Text);
        }

        private void grv_products_search_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grv_products_search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.grv_product_buy.Refresh();
            if(this.grv_product_buy.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in this.grv_product_buy.Rows)
                {
                    if (this.grv_products_search.Rows[e.RowIndex].Cells["productSearchID"].Value.ToString() == row.Cells["productID"].Value.ToString() )
                    {

                        int amountUpdate = int.Parse(row.Cells["productAmount"].Value.ToString()) + int.Parse(this.txt_aounnt_input.Text);
                        if (amountUpdate > int.Parse(this.grv_products_search.Rows[e.RowIndex].Cells["SL_TON"].Value.ToString()))
                        {
                            MessageBox.Show("Vượt quá số lượng trong kho", "Không thể thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            row.Cells["productAmount"].Value = amountUpdate;
                            row.Cells["sumOfPrice"].Value = amountUpdate * int.Parse(this.grv_products_search.Rows[e.RowIndex].Cells["grv_c_search_don_gia"].Value.ToString());
                            this.grv_product_buy.Refresh();
                            return;
                        }
                    }
                  
                }

                addListBuy(e.RowIndex, int.Parse(this.txt_aounnt_input.Text));
            }else
                addListBuy(e.RowIndex, int.Parse(this.txt_aounnt_input.Text));

        }
        
        private void addListBuy(int rowIndex, int amount)
        {
            this.tbProductBuy.Rows.Add(
                this.grv_products_search.Rows[rowIndex].Cells["productSearchID"].Value,
                this.grv_products_search.Rows[rowIndex].Cells["productSearchName"].Value,
                this.txt_aounnt_input.Text,
                int.Parse(this.grv_products_search.Rows[rowIndex].Cells["grv_c_search_don_gia"].Value.ToString()) * int.Parse(this.txt_aounnt_input.Text)
                );
            this.grv_product_buy.DataSource = this.tbProductBuy;

        }

        private void btn_up_Click(object sender, EventArgs e)
        {

            this.grv_product_buy.Refresh();
            if(this.grv_product_buy.Rows.Count > 0)
            {
                int rowIndex = this.grv_product_buy.CurrentCell.RowIndex;
                int amountUpdate = int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value.ToString()) + 1;
                int totalPrice = (int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["sumOfPrice"].Value.ToString()) / int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value.ToString())) * amountUpdate;

                this.grv_product_buy.Rows[rowIndex].Cells["sumOfPrice"].Value = totalPrice;
                this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value = amountUpdate ;
                this.grv_product_buy.Refresh();

            }else
                MessageBox.Show("Chưa có sản phẩm", "Không thể tăng số lượng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            this.grv_product_buy.Refresh();
            if (this.grv_product_buy.Rows.Count > 0)
            {
                int rowIndex = this.grv_product_buy.CurrentCell.RowIndex;
                int amountUpdate = int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value.ToString()) + -1;
                int totalPrice = (int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["sumOfPrice"].Value.ToString()) / int.Parse(this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value.ToString())) * amountUpdate;

                this.grv_product_buy.Rows[rowIndex].Cells["sumOfPrice"].Value = totalPrice;
                this.grv_product_buy.Rows[rowIndex].Cells["productAmount"].Value = amountUpdate;
                if (totalPrice <= 0)
                    this.grv_product_buy.Rows.RemoveAt(rowIndex);
                this.grv_product_buy.Refresh();

            }
            else
                MessageBox.Show("Chưa có sản phẩm", "Không thể giảm số lượng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.grv_product_buy.Refresh();
            if(this.grv_product_buy.Rows.Count > 0)
            {
                this.grv_product_buy.Rows.RemoveAt(this.grv_product_buy.CurrentCell.RowIndex);
                this.grv_product_buy.Refresh();
            }
            else
                MessageBox.Show("Chưa có sản phẩm", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            this.tbProductBuy.Clear();
            this.grv_product_buy.DataSource = this.tbProductBuy;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if( !(this.tbProductBuy.Rows.Count <= 0))
            {
                new frm_TinhTien(this.currentLoginUser, (DataTable) this.grv_product_buy.DataSource, this.lb_bill_id.Text.ToString()).ShowDialog();
            }
        }
    }
}
